﻿using System;
using BREPipelineFramework.Helpers;
using BREPipelineFramework.SampleInstructions.Instructions;
using BREPipelineFramework.Helpers.Tracing;

namespace BREPipelineFramework.SampleInstructions.MetaInstructions
{
    public class ContextMetaInstructions : BREPipelineMetaInstructionBase
    {
        #region Private Properties

        private SetContextPropertyFromXPathResultPipelineInstruction setContextPropertyFromXPathResultPipelineInstruction = null;

        #endregion

        #region Public Instruction Setup Methods

        /// <summary>
        /// Setup an Instruction that will remove a context property from a message
        /// </summary>
        /// <param name="propertyName">The name of the context property to remove</param>
        /// <param name="propertyNamespace">The namespace of the context property to remove</param>
        public void RemoveContextProperty(string propertyName, string propertyNamespace)
        {
            RemoveContextPropertyPipelineInstruction instruction = new RemoveContextPropertyPipelineInstruction(propertyName, propertyNamespace);
            base.AddInstruction(instruction);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within any namespace
        /// </summary>
        /// <param name="propertyName">The name of the context property</param>
        /// <param name="propertyNamespace">The namespace of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetCustomContextProperty(string propertyName, string propertyNamespace, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetContextPropertyPipelineInstruction instruction = new SetContextPropertyPipelineInstruction(propertyName, propertyNamespace, value, promotion, type);
            base.AddInstruction(instruction);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the BTS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetGlobalPropertySchemasContextProperty(BizTalkGlobalPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._BTSPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the ErrorReport namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetErrorReportContextProperty(BizTalkErrorReportPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._ErrorReportPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the FILE namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetFILEContextProperty(BizTalkFilePropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._FILEPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the FTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetFTPContextProperty(BizTalkFTPPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._FTPPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the HTTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetHTTPContextProperty(BizTalkHTTPPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._HTTPPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the LEGACY namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetLEGACYContextProperty(BizTalkLegacyPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._LEGACYPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the MessageTracking namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetMessageTrackingContextProperty(BizTalkMessageTrackingPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._MessageTrackingPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the MIME namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetMIMETrackingContextProperty(BizTalkMIMEPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._MIMEPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the MSMQT namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetMSMQTContextProperty(BizTalkMSMQTPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._MSMQTPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the POP3 namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetPOP3ContextProperty(BizTalkPOP3PropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._POP3PropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the SMTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetSMTPContextProperty(BizTalkSMTPPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SMTPPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the SOAP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetSOAPContextProperty(BizTalkSOAPPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SOAPPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the SQL namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetSQLContextProperty(BizTalkSQLPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SQLPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the WSS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetWSSContextProperty(BizTalkWSSPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SharePointPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the XMLNORM namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetXMLNORMContextProperty(BizTalkXMLNORMPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._XMLNormPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the Microsoft.BizTalk.XLANGs.BTXEngine namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetXLANGsBTXEngineContextProperty(BizTalkXLANGSBTXEnginePropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._XLANGSPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the WCF namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetWCFPropertySchemasContextProperty(BizTalkWCFPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._WCFPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the BTF2 namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetBTF2PropertySchemasContextProperty(BizTalkBTF2PropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._BTF2PropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the EDI namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetEDIPropertySchemasContextProperty(BizTalkEDIPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._EDIPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the EdiIntAS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetEdiIntASPropertySchemasContextProperty(BizTalkEdiIntASPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._EDIAS2PropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the EdiOverride namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetEdiOverridePropertySchemasContextProperty(BizTalkEdiOverridePropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._EDIOverridePropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the SFTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetSFTPPropertySchemasContextProperty(BizTalkSFTPPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SFTPPropertyNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified value to a context property within the SBMessaging namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="value">The value to be written/promoted to the context</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetSBMessagingPropertySchemasContextProperty(BizTalkSBMessagingPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._SBMessagingPropertyNamespace, value, promotion, type);
        }

        public void SetESBItineraryPropertySchemasContextProperty(BizTalkESBItineraryPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._ESBItineraryNamespace, value, promotion, type);
        }

        public void SetESBExceptionPropertySchemasContextProperty(BizTalkESBExceptionPropertySchemaEnum property, object value, ContextInstructionTypeEnum promotion, TypeEnum type)
        {
            SetCustomContextProperty(property.ToString(), ContextPropertyNamespaces._ESBExceptionNamespace, value, promotion, type);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified a value read in from the SSO Database to a context property within any namespace
        /// </summary>
        /// <param name="propertyName">The name of the context property</param>
        /// <param name="propertyNamespace">The namespace of the context property</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="_SSOApplication">The name of the SSO Application</param>
        /// <param name="_SSOKey">The name of the SSO Key in the key/value pair</param>
        /// <param name="type">The type to cast the value to</param>
        public void SetContextPropertyFromSSOConfig(string propertyName, string propertyNamespace, ContextInstructionTypeEnum promotion, string _SSOApplication, string _SSOKey, TypeEnum type)
        {
            SetContextPropertyFromSSOConfigPipelineInstruction instruction = new SetContextPropertyFromSSOConfigPipelineInstruction(propertyName, propertyNamespace, promotion, _SSOApplication, _SSOKey, type);
            base.AddInstruction(instruction);
        }

        public void SetMessageTypeContextPropertyOnXMLMessage()
        {
            SetMessageTypeContextProperty instruction = new Instructions.SetMessageTypeContextProperty();
            base.AddInstruction(instruction);
        }

        /// <summary>
        /// Setup an Instruction that will either promote or write a specified a value that is the result of an XPath Expression to a context property within any namespace
        /// </summary>
        /// <param name="propertyName">The name of the context property</param>
        /// <param name="propertyNamespace">The namespace of the context property</param>
        /// <param name="promotion">Whether to write or promote the context property</param>
        /// <param name="_XPathResultType">Whether the resulting node's value, name, or namspace should be treated as the result</param>
        /// <param name="_XPathQuery">The XPath Expression</param>
        /// <param name="type">The type to cast the value to</param>
        /// <param name="exceptionIfNotFound">Whether or not to thrown an exception if the XPath expression does not evaluate</param>
        public void SetContextPropertyFromXPathResult(string propertyName, string propertyNamespace, ContextInstructionTypeEnum promotion, XPathResultTypeEnum _XPathResultType, string _XPathQuery, TypeEnum type, bool exceptionIfNotFound)
        {
            if (setContextPropertyFromXPathResultPipelineInstruction == null)
            {
                setContextPropertyFromXPathResultPipelineInstruction = new SetContextPropertyFromXPathResultPipelineInstruction();
                base.AddInstruction(setContextPropertyFromXPathResultPipelineInstruction);
            }

            setContextPropertyFromXPathResultPipelineInstruction.AddXPathInstruction(new XPathInstruction(_XPathQuery, promotion, _XPathResultType, propertyName, propertyNamespace, type, exceptionIfNotFound));
        }

        #endregion

        //#region Public Helper Methods

        /// <summary>
        /// Get the object value of a context property in any namespace
        /// </summary>
        /// <param name="Name">The name of the context property</param>
        /// <param name="Namespace">The namespace of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetContextProperty(string Name, string Namespace, FailureActionEnum failureAction)
        {
            object property = base.InMsg.Context.Read(Name, Namespace);
            string propertyValue = null;

            if (property != null)
            {
                propertyValue = property.ToString();
                TraceManager.PipelineComponent.TraceInfo("{0} - Got value {1} for context property {2}#{3}", CallToken, propertyValue, Namespace, Name);
            }
            else
            {
                TraceManager.PipelineComponent.TraceInfo("{0} - Context property {1}#{2} not found", CallToken, Namespace, Name, propertyValue);
                
                if (failureAction == FailureActionEnum.Exception)
                {
                    Exception exc = new Exception("Unable to get context property " + Name + " in namespace " + Namespace + ".");
                    base.SetException(exc);
                }
                else if (failureAction == FailureActionEnum.BlankOrDefaultValue)
                {
                    propertyValue = string.Empty;
                }
                else if (failureAction == FailureActionEnum.Null)
                {
                    // Do nothing, leave as null
                }
            }

            return propertyValue;
        }

        /// <summary>
        /// Get the object value of a context property in the BTS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetGlobalPropertySchemasContextProperty(BizTalkGlobalPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._BTSPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the WCF namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetWCFPropertySchemasContextProperty(BizTalkWCFPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._WCFPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the BTF2 namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetBTF2PropertySchemasContextProperty(BizTalkBTF2PropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._BTF2PropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the ErrorReport namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetErrorReportPropertySchemasContextProperty(BizTalkErrorReportPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._ErrorReportPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the FILE namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetFILEPropertySchemasContextProperty(BizTalkFilePropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._FILEPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the FTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetFTPPropertySchemasContextProperty(BizTalkFTPPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._FTPPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the HTTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetHTTPPropertySchemasContextProperty(BizTalkHTTPPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._HTTPPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the LEGACY namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetLEGACYPropertySchemasContextProperty(BizTalkLegacyPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._LEGACYPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the MessageTracking namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetMessageTrackingPropertySchemasContextProperty(BizTalkMessageTrackingPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._MessageTrackingPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the MIME namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetMIMEPropertySchemasContextProperty(BizTalkMIMEPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._MIMEPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the MSMQT namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetMSMQTPropertySchemasContextProperty(BizTalkMSMQTPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._MSMQTPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the POP3 namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetPOP3PropertySchemasContextProperty(BizTalkPOP3PropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._POP3PropertyNamespace, failureAction);
        }


        /// <summary>
        /// Get the object value of a context property in the SMTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetSMTPPropertySchemasContextProperty(BizTalkSMTPPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SMTPPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the SOAP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetSOAPPropertySchemasContextProperty(BizTalkSOAPPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SOAPPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the SQL namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetSQLPropertySchemasContextProperty(BizTalkSQLPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SQLPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the WSS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetWSSPropertySchemasContextProperty(BizTalkWSSPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SharePointPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the Microsoft.BizTalk.XLANGs.BTXEngine namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetXLANGSBTXEnginePropertySchemasContextProperty(BizTalkXLANGSBTXEnginePropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._XLANGSPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the XMLNORM namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetXMLNORMPropertySchemasContextProperty(BizTalkXMLNORMPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._XMLNormPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the EDI namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetEDIPropertySchemasContextProperty(BizTalkEDIPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._EDIPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the EdiIntAS namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetEdiIntASPropertySchemasContextProperty(BizTalkEdiIntASPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._EDIAS2PropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the EdiOverride namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetEdiOverridePropertySchemasContextProperty(BizTalkEdiOverridePropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._EDIOverridePropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the SFTP namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetSFTPPropertySchemasContextProperty(BizTalkSFTPPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SFTPPropertyNamespace, failureAction);
        }

        /// <summary>
        /// Get the object value of a context property in the SBMessaging namespace
        /// </summary>
        /// <param name="property">The name of the context property</param>
        /// <param name="failureAction">Whether to throw an exception or return a blank string if the property is not found</param>
        /// <returns>The object value of the context property</returns>
        public string GetSBMessagingPropertySchemasContextProperty(BizTalkSBMessagingPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._SBMessagingPropertyNamespace, failureAction);
        }

        public string GetESBItineraryPropertySchemasContextProperty(BizTalkESBItineraryPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._ESBItineraryNamespace, failureAction);
        }

        public string GetESBExceptionPropertySchemasContextProperty(BizTalkESBExceptionPropertySchemaEnum property, FailureActionEnum failureAction)
        {
            return GetContextProperty(property.ToString(), ContextPropertyNamespaces._ESBExceptionNamespace, failureAction);
        }

        /// <summary>
        /// Create an SSO ticket so that credentials on a compatible adapter can be read in from an SSO credential store
        /// </summary>
        public void CreateSSOTicket()
        {
            CreateSSOTicketInstruction instruction = new CreateSSOTicketInstruction();
            base.AddInstruction(instruction);
        }

        //#endregion
    }
}
