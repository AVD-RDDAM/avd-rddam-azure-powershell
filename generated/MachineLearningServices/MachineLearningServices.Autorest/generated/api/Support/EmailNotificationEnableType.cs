// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support
{

    /// <summary>Enum to determine the email notification type.</summary>
    public partial struct EmailNotificationEnableType :
        System.IEquatable<EmailNotificationEnableType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType JobCancelled = @"JobCancelled";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType JobCompleted = @"JobCompleted";

        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType JobFailed = @"JobFailed";

        /// <summary>
        /// the value for an instance of the <see cref="EmailNotificationEnableType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EmailNotificationEnableType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EmailNotificationEnableType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EmailNotificationEnableType(global::System.Convert.ToString(value));
        }

        /// <summary>
        /// Creates an instance of the <see cref="EmailNotificationEnableType"/> Enum class.
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EmailNotificationEnableType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Compares values of enum type EmailNotificationEnableType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EmailNotificationEnableType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EmailNotificationEnableType && Equals((EmailNotificationEnableType)obj);
        }

        /// <summary>Returns hashCode for enum EmailNotificationEnableType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EmailNotificationEnableType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EmailNotificationEnableType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EmailNotificationEnableType" />.</param>

        public static implicit operator EmailNotificationEnableType(string value)
        {
            return new EmailNotificationEnableType(value);
        }

        /// <summary>Implicit operator to convert EmailNotificationEnableType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EmailNotificationEnableType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EmailNotificationEnableType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EmailNotificationEnableType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e1, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType e2)
        {
            return e2.Equals(e1);
        }
    }
}