using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xceed.Words.NET;

namespace DoxXCode.Utility
{
    [Serializable]
    public class DoxXCodeDocument
    {
        [JsonProperty]
        private DocX template;
        [JsonIgnore]
        private DocX outputDocx;
        [JsonIgnore]
        private Dictionary<string, VariableInstanceData> variableInstances = new Dictionary<string, VariableInstanceData>();
        [JsonIgnore]
        private HashSet<string> variables = new HashSet<string>();

        public DocX Template => template;
        public DocX OutputDocx => outputDocx;

        public static DoxXCodeDocument LoadFromTemplate(string filepath)
        {
            DoxXCodeDocument docXCodeDocument = new DoxXCodeDocument();
            try
            {
                docXCodeDocument.template = DocX.Load(filepath);
                docXCodeDocument.LoadFromTemplate();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

            return docXCodeDocument;
        }
        public static DoxXCodeDocument LoadFromTemplate(DocX template)
        {
            DoxXCodeDocument docXCodeDocument = new DoxXCodeDocument();
            try
            {
                docXCodeDocument.template = template;
                docXCodeDocument.LoadFromTemplate();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }

            return docXCodeDocument;
        }

        public void LoadFromTemplate()
        {
            ResetWorkingCopy();
            List<int> variablesStarts = template.FindAll("[v:");
            foreach (var variableStart in variablesStarts)
            {
                int variableEnd = template.Text.IndexOf(']', variableStart);
                string variableString = template.Text.Substring(variableStart, variableEnd - variableStart + 1);
                var variableData = VariableInstanceData.Parse(variableString);
                if (!variableInstances.ContainsKey(variableString))
                {
                    variableInstances.Add(variableString, variableData);
                }
                if (!variables.Contains(variableData.name))
                {
                    variables.Add(variableData.name);
                }
            }
        }

        public void ResetWorkingCopy()
        {
            if (outputDocx != null)
            {
                outputDocx.Dispose();
            }
            if (template != null)
            {
                outputDocx = template.Copy() as DocX;
            }
        }

        public HashSet<string> GetVariables()
        {
            return new HashSet<string>(variables);
        }

        public void GenerateOutput(Dictionary<string, object> variableValues)
        {
            ResetWorkingCopy();
            foreach (var variable in variableInstances)
            {
                if (variableValues.ContainsKey(variable.Value.name))
                {
                    outputDocx.ReplaceText(variable.Key, variable.Value.GetString(variableValues[variable.Value.name]));
                }
            }
        }

        public class VariableInstanceData
        {
            public string name;
            public string formatString;


            public string GetString(object value)
            {
                return string.Format($"{{0:{formatString}}}", value);
            }

            public static VariableInstanceData Parse(string variableString)
            {
                if (variableString.StartsWith("[") && variableString.EndsWith("]"))
                {
                    VariableInstanceData variableData = new VariableInstanceData();
                    variableString = variableString.TrimStart('[').TrimEnd(']');
                    string[] parts = variableString.Split(';');
                    foreach (var part in parts)
                    {
                        if (part.StartsWith("v:"))
                        {
                            variableData.name = part.Substring(2);
                        }
                        else if (part.StartsWith("f:"))
                        {
                            variableData.formatString = part.Substring(2);
                        }
                    }

                    return variableData;
                }
                else
                {
                    throw new ArgumentException("Invalid variable string to parse.");
                }
            }
        }
    }
}
