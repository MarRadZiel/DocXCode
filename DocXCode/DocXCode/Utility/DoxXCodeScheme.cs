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
    public class DoxXCodeScheme
    {
        private DocX template;
        [JsonProperty]
        private string schemeName;
        [JsonProperty]
        private Dictionary<string, VariableType> variableTypes = new Dictionary<string, Utility.VariableType>();

        [JsonProperty]
        private byte[] templateBytes;
        [JsonProperty]
        private string templatePath;

        public string SchemeName => schemeName;

        public bool HasTemplate => template != null;
        public DocX Template => template;
        public string TemplatePath => templatePath;

        public DoxXCodeDocument GenerateDocument()
        {
            return DoxXCodeDocument.LoadFromTemplate(template);
        }

        public void SetTemplate(DocX template)
        {
            this.template = template;
        }

        public void SetName(string name)
        {
            schemeName = name;
        }

        public void SetVariableType(string variableName, VariableType variableType)
        {
            if (variableTypes.ContainsKey(variableName))
            {
                variableTypes[variableName] = variableType;
            }
            else
            {
                variableTypes.Add(variableName, variableType);
            }
        }

        public VariableType GetVariableType(string variableName)
        {
            if (variableTypes.ContainsKey(variableName))
            {
                return variableTypes[variableName];
            }
            return VariableType.Invalid;
        }
        public HashSet<VariableData> GetVariablesData()
        {
            HashSet<VariableData> result = new HashSet<VariableData>();
            foreach (var variableEntry in variableTypes)
            {
                result.Add(new VariableData
                {
                    name = variableEntry.Key,
                    type = variableEntry.Value
                });
            }
            return result;
        }

        public static DoxXCodeScheme LoadFromFile(string filepath, bool loadTemplate = true)
        {
            DoxXCodeScheme loadedScheme;
            if (File.Exists(filepath))
            {
                string json = null;
                using (StreamReader sr = new StreamReader(filepath))
                {
                    json = sr.ReadToEnd();
                }

                loadedScheme = LoadFromJSON(json, loadTemplate);
            }
            else
            {
                throw new FileLoadException();
            }

            return loadedScheme;
        }
        public static DoxXCodeScheme LoadFromJSON(string json, bool loadTemplate = true)
        {
            DoxXCodeScheme loadedScheme;
            try
            {
                loadedScheme = JsonConvert.DeserializeObject<DoxXCodeScheme>(json);
                if (loadTemplate)
                {
                    if (loadedScheme.templateBytes != null && loadedScheme.templateBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(loadedScheme.templateBytes))
                        {
                            loadedScheme.template = DocX.Load(ms);
                        }
                    }
                    else if (!string.IsNullOrEmpty(loadedScheme.templatePath) && File.Exists(loadedScheme.templatePath))
                    {
                        loadedScheme.template = DocX.Load(loadedScheme.templatePath);
                    }
                }
            }
            catch
            {
                throw;
            }

            return loadedScheme;
        }

        public static string ToJson(DoxXCodeScheme docXCodeScheme, bool includeTemplate)
        {
            if (includeTemplate)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    docXCodeScheme.template.SaveAs(ms);
                    docXCodeScheme.templateBytes = ms.ToArray();
                }
            }

            return JsonConvert.SerializeObject(docXCodeScheme);
        }
    }

    [Serializable]
    public class VariableData
    {
        public string name;
        public VariableType type;
    }

    public enum VariableType
    {
        Invalid = -1,
        Boolean,
        Integer,
        Float,
        Date,
        String,


        Count
    }
}
