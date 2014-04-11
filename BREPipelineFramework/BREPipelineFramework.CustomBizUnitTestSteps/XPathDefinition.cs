﻿namespace BREPipelineFramework.CustomBizUnitTestSteps
{
    ///<summary>
    /// Defines an XPath expression to be executed with the expected result
    ///</summary>
    public class XPathDefinition
    {
        public XPathDefinition()
        {

        }

        ///<summary>
        /// A textural desciption of the expected result
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        /// the XPath expression to be executed
        ///</summary>
        public string XPath { get; set; }

        ///<summary>
        /// The expected result of the XPath
        ///</summary>
        public string Value { get; set; }

        ///<summary>
        /// The name of the context key which maybe used as the expected result
        ///</summary>
        public string ContextKey { get; set; }

        ///<summary>
        /// The regex expression to run against the XPath result
        ///</summary>
        public string RegexValue { get; set; }
    }
}
