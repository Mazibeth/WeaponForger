﻿// ///////////////////////////////
// // Author: Derick Rhodes     //
// // Creation Date: 11/23/2015 //
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
#line 1 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class MaterialParser : MaterialParserBase
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
using WeaponForger.Enums;
using WeaponForger.Models;

namespace WeaponForger.Data
{
    public class MaterialLibrary
    {
        public MaterialLibrary()
        {
            MaterialsList = new List<Material>();

");

#line 23 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
            foreach (var Material in Materials)
            {
#line default
#line hidden
                Write("            var ");

#line 24 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Regex.Replace(Material.Name, @"\s+", "")));

#line default
#line hidden
                Write("Material = new Material\r\n            {\r\n                Id = ");

#line 26 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Id));

#line default
#line hidden
                Write(",\r\n                Name = \"");

#line 27 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Name));

#line default
#line hidden
                Write("\",\r\n                Weight = ");

#line 28 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Weight));

#line default
#line hidden
                Write(",\r\n                Hardness = ");

#line 29 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Hardness));

#line default
#line hidden
                Write(",\r\n                Resistance = ");

#line 30 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Resistance));

#line default
#line hidden
                Write(",\r\n                Type = MaterialType.");

#line 31 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Material.Type));

#line default
#line hidden
                Write("\r\n            };\r\n            MaterialsList.Add(");

#line 33 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
                Write(ToStringHelper.ToStringWithCulture(Regex.Replace(Material.Name, @"\s+", "")));

#line default
#line hidden
                Write("Material);\r\n");

#line 34 "C:\Users\fezzi\Documents\Visual Studio 2015\Projects\WeaponForger\WeaponForger.Tests\Tools\MaterialParser.tt"
            }

#line default
#line hidden
            Write("        }\r\n\r\n        public List<Material> MaterialsList { get; set; } \r\n    }\r\n}" +
                  "\r\n");
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
    public class MaterialParserBase
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