# DocXCode
Simple program that helps with creating many documents from a single template.

## How it works 
DocXCode operates on templates and schemes:
- **Template** is a base *.docx file that will be modified to generate the final document. Editable parts of the template must be constructed using DocXCode syntax.
- **Scheme** is a DocXCode-produced JSON file that contains information about types of all the variables occuring in the template and optionally stores the template itself.

### Creating a template
Creating a DocXCode template is as simple as creating or editting *.docx document in the prefrerred editor.
Only thing to remember is constructing all editable parts with DocXCode syntax.<br/>
- [v:*variableName*] - text will be swapped with value of variable specified by *variableName*,
- [v:*variableName*f:*formatString*] - text will be swapped with value of variable specified by *variableName* using formatting string specified by *formatString* (supports: [date and time formats](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings), [standard numeric formats](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings), [custom numeric formats](https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings))

### Creating a scheme
After the template is provided by the user, DocXCode helps to create a scheme that will be used in the generation process.
It reads all variable occurencies in the template document, and asks user to define their types.
When all types are provided, user can save the scheme for future use. Template can be embeded into the created scheme.

### Generating the final document
After the user has provided the scheme, DocXCode will create a form that allow specifying all variables values.
When all fields are filled with valid values, output document can be generated. 
If there is no template embeded in the provided scheme, user must specify it before generation.