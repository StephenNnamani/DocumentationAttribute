# DocumentationAttribute
This program was built to display the descriptions of the methods and classes. It uses reflection to display the attributes of each member of the assembly.

# usage
Run this code on a program.cs file to get the documentation from the PersonalModel sample code
```C#
    DocumentationAttribute.GetDocs(typeof(PersonModel));
```

```C#
    [Documentation("This is the number of years the person has lived", "Only takes an integer (int)")]
        public int Age { get; set; }
```
