﻿// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/29/2015 //
// // Last Updated: 12/12/2015  //
// ///////////////////////////////

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace WeaponForger.Tests.Tools
{
    /// <summary>
    ///     Class to produce the template output
    /// </summary>
#line 1 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class SchematicParser : SchematicParserBase
    {
        /// <summary>
        ///     Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            Write(@"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class SchematicLibrary
    {
        public SchematicLibrary()
        {
            Schematics = new List<Schematic>();

");

#line 22 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
            foreach (var Schematic in Schematics)
            {
#line default
#line hidden
                Write("            var ");

#line 23 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Regex.Replace(Schematic.Name, @"\s+", "")));

#line default
#line hidden
                Write("Schematic = new Schematic\r\n            {\r\n                Id = ");

#line 25 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Id));

#line default
#line hidden
                Write(",\r\n                Name = \"");

#line 26 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Name));

#line default
#line hidden
                Write("\",\r\n                Slot = new char[]\r\n                {\r\n\t\t\t\t\t\'");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[0]));

#line default
#line hidden
                Write("\',\'");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[1]));

#line default
#line hidden
                Write("\',\'");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[2]));

#line default
#line hidden
                Write("\',\'");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[3]));

#line default
#line hidden
                Write("\',\'");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[4]));

#line default
#line hidden
                Write("\', \r\n                    \'");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[5]));

#line default
#line hidden
                Write("\',\'");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[6]));

#line default
#line hidden
                Write("\',\'");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[7]));

#line default
#line hidden
                Write("\',\'");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[8]));

#line default
#line hidden
                Write("\',\'");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[9]));

#line default
#line hidden
                Write("\', \r\n                    \'");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[10]));

#line default
#line hidden
                Write("\',\'");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[11]));

#line default
#line hidden
                Write("\',\'");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[12]));

#line default
#line hidden
                Write("\',\'");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[13]));

#line default
#line hidden
                Write("\',\'");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[14]));

#line default
#line hidden
                Write("\', \r\n                    \'");

#line 32 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[15]));

#line default
#line hidden
                Write("\',\'");

#line 32 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[16]));

#line default
#line hidden
                Write("\',\'");

#line 32 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[17]));

#line default
#line hidden
                Write("\',\'");

#line 32 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[18]));

#line default
#line hidden
                Write("\',\'");

#line 32 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[19]));

#line default
#line hidden
                Write("\', \r\n                    \'");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[20]));

#line default
#line hidden
                Write("\',\'");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[21]));

#line default
#line hidden
                Write("\',\'");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[22]));

#line default
#line hidden
                Write("\',\'");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[23]));

#line default
#line hidden
                Write("\',\'");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Schematic.Slot[24]));

#line default
#line hidden
                Write("\'\r\n                }\r\n            };\r\n            Schematics.Add(");

#line 36 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Regex.Replace(Schematic.Name, @"\s+", "")));

#line default
#line hidden
                Write("Schematic);\r\n");

#line 37 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\SchematicParser.tt"
            }

#line default
#line hidden
            Write("        }\r\n\r\n        public List<Schematic> Schematics { get; set; } \r\n    }\r\n}\r\n" +
                  "");
            return GenerationEnvironment.ToString();
        }
    }

#line default
#line hidden

    #region Base class

    /// <summary>
    ///     Base class for this transformation
    /// </summary>
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class SchematicParserBase
    {
        #region Fields

        private StringBuilder generationEnvironmentField;
        private CompilerErrorCollection errorsField;
        private List<int> indentLengthsField;
        private bool endsWithNewline;

        #endregion

        #region Properties

        /// <summary>
        ///     The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected StringBuilder GenerationEnvironment
        {
            get
            {
                if ((generationEnvironmentField == null))
                {
                    generationEnvironmentField = new StringBuilder();
                }
                return generationEnvironmentField;
            }
            set { generationEnvironmentField = value; }
        }

        /// <summary>
        ///     The error collection for the generation process
        /// </summary>
        public CompilerErrorCollection Errors
        {
            get
            {
                if ((errorsField == null))
                {
                    errorsField = new CompilerErrorCollection();
                }
                return errorsField;
            }
        }

        /// <summary>
        ///     A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private List<int> indentLengths
        {
            get
            {
                if ((indentLengthsField == null))
                {
                    indentLengthsField = new List<int>();
                }
                return indentLengthsField;
            }
        }

        /// <summary>
        ///     Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent { get; private set; } = "";

        /// <summary>
        ///     Current transformation session
        /// </summary>
        public virtual IDictionary<string, object> Session { get; set; }

        #endregion

        #region Transform-time helpers

        /// <summary>
        ///     Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((GenerationEnvironment.Length == 0)
                 || endsWithNewline))
            {
                GenerationEnvironment.Append(CurrentIndent);
                endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(Environment.NewLine, StringComparison.CurrentCulture))
            {
                endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((CurrentIndent.Length == 0))
            {
                GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(Environment.NewLine, (Environment.NewLine + CurrentIndent));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (endsWithNewline)
            {
                GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - CurrentIndent.Length));
            }
            else
            {
                GenerationEnvironment.Append(textToAppend);
            }
        }

        /// <summary>
        ///     Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            Write(textToAppend);
            GenerationEnvironment.AppendLine();
            endsWithNewline = true;
        }

        /// <summary>
        ///     Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            Write(string.Format(CultureInfo.CurrentCulture, format, args));
        }

        /// <summary>
        ///     Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(CultureInfo.CurrentCulture, format, args));
        }

        /// <summary>
        ///     Raise an error
        /// </summary>
        public void Error(string message)
        {
            var error = new CompilerError();
            error.ErrorText = message;
            Errors.Add(error);
        }

        /// <summary>
        ///     Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            var error = new CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            Errors.Add(error);
        }

        /// <summary>
        ///     Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new ArgumentNullException("indent");
            }
            CurrentIndent = (CurrentIndent + indent);
            indentLengths.Add(indent.Length);
        }

        /// <summary>
        ///     Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            var returnValue = "";
            if ((indentLengths.Count > 0))
            {
                var indentLength = indentLengths[(indentLengths.Count - 1)];
                indentLengths.RemoveAt((indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = CurrentIndent.Substring((CurrentIndent.Length - indentLength));
                    CurrentIndent = CurrentIndent.Remove((CurrentIndent.Length - indentLength));
                }
            }
            return returnValue;
        }

        /// <summary>
        ///     Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            indentLengths.Clear();
            CurrentIndent = "";
        }

        #endregion

        #region ToString Helpers

        /// <summary>
        ///     Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private IFormatProvider formatProviderField = CultureInfo.InvariantCulture;

            /// <summary>
            ///     Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public IFormatProvider FormatProvider
            {
                get { return formatProviderField; }
                set
                {
                    if ((value != null))
                    {
                        formatProviderField = value;
                    }
                }
            }

            /// <summary>
            ///     This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new ArgumentNullException("objectToConvert");
                }
                var t = objectToConvert.GetType();
                var method = t.GetMethod("ToString", new[]
                {
                    typeof (IFormatProvider)
                });
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                return ((string) (method.Invoke(objectToConvert, new object[]
                {
                    formatProviderField
                })));
            }
        }

        /// <summary>
        ///     Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper { get; } = new ToStringInstanceHelper();

        #endregion
    }

    #endregion
}