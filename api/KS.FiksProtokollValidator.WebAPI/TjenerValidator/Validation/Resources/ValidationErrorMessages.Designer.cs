﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KS.FiksProtokollValidator.WebAPI.TjenerValidator.Validation.Resources {
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ValidationErrorMessages {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ValidationErrorMessages() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("KS.FiksProtokollValidator.WebAPI.TjenerValidator.Validation.Resources.ValidationErrorMessages", typeof(ValidationErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string InvalidPayloadFileFormatMessage {
            get {
                return ResourceManager.GetString("InvalidPayloadFileFormatMessage", resourceCulture);
            }
        }
        
        public static string InvalidPayloadFilename {
            get {
                return ResourceManager.GetString("InvalidPayloadFilename", resourceCulture);
            }
        }
        
        public static string MissingAttributeOnPayloadElement {
            get {
                return ResourceManager.GetString("MissingAttributeOnPayloadElement", resourceCulture);
            }
        }
        
        public static string MissingJsonPayload {
            get {
                return ResourceManager.GetString("MissingJsonPayload", resourceCulture);
            }
        }
        
        public static string MissingJsonPayloadToken {
            get {
                return ResourceManager.GetString("MissingJsonPayloadToken", resourceCulture);
            }
        }
        
        public static string MissingPayloadElement {
            get {
                return ResourceManager.GetString("MissingPayloadElement", resourceCulture);
            }
        }
        
        public static string MissingPayloadFileMessage {
            get {
                return ResourceManager.GetString("MissingPayloadFileMessage", resourceCulture);
            }
        }
        
        public static string MissingResponseMessage {
            get {
                return ResourceManager.GetString("MissingResponseMessage", resourceCulture);
            }
        }
        
        public static string MissingValueOnPayloadElement {
            get {
                return ResourceManager.GetString("MissingValueOnPayloadElement", resourceCulture);
            }
        }
        
        public static string UnexpectedPayloadFileMessage {
            get {
                return ResourceManager.GetString("UnexpectedPayloadFileMessage", resourceCulture);
            }
        }
        
        public static string UnexpectedResponseMessage {
            get {
                return ResourceManager.GetString("UnexpectedResponseMessage", resourceCulture);
            }
        }
        
        public static string WrongValueOnJsonPayloadKey {
            get {
                return ResourceManager.GetString("WrongValueOnJsonPayloadKey", resourceCulture);
            }
        }
        
        public static string WrongValueOnPayloadElement {
            get {
                return ResourceManager.GetString("WrongValueOnPayloadElement", resourceCulture);
            }
        }
        
        public static string FailedRegexPattern {
            get {
                return ResourceManager.GetString("FailedRegexPattern", resourceCulture);
            }
        }
        
        public static string CouldNotFindSaksmappe {
            get {
                return ResourceManager.GetString("CouldNotFindSaksmappe", resourceCulture);
            }
        }
        
        public static string TooLongResultListAccordingToTakeParameter {
            get {
                return ResourceManager.GetString("TooLongResultListAccordingToTakeParameter", resourceCulture);
            }
        }
        
        public static string ResultDontMatchSearchText {
            get {
                return ResourceManager.GetString("ResultDontMatchSearchText", resourceCulture);
            }
        }
        
        public static string FoundUnexpectedResultTypeAccordingToRespons {
            get {
                return ResourceManager.GetString("FoundUnexpectedResultTypeAccordingToRespons", resourceCulture);
            }
        }
        
        public static string CouldNotParseSokeresultat {
            get {
                return ResourceManager.GetString("CouldNotParseSokeresultat", resourceCulture);
            }
        }
        
        public static string SokeresultatIsNull {
            get {
                return ResourceManager.GetString("SokeresultatIsNull", resourceCulture);
            }
        }
        
        public static string MissingAsiceSigning {
            get {
                return ResourceManager.GetString("MissingAsiceSigning", resourceCulture);
            }
        }
        
        public static string PayloadError {
            get {
                return ResourceManager.GetString("PayloadError", resourceCulture);
            }
        }
    }
}