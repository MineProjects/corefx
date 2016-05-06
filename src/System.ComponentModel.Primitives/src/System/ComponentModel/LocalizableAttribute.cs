// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel
{
    /// <summary>
    ///    <para>Specifies whether a property should be localized.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class LocalizableAttribute : Attribute, IIsDefaultAttribute
    {
        private bool _isLocalizable = false;

        /// <summary>
        ///    <para>
        ///       Initializes a new instance of the <see cref='System.ComponentModel.LocalizableAttribute'/> class.
        ///    </para>
        /// </summary>
        public LocalizableAttribute(bool isLocalizable)
        {
            _isLocalizable = isLocalizable;
        }

        /// <summary>
        ///    <para>
        ///       Gets a value indicating whether
        ///       a property should be localized.
        ///    </para>
        /// </summary>
        public bool IsLocalizable
        {
            get
            {
                return _isLocalizable;
            }
        }

        /// <summary>
        ///    <para>
        ///       Specifies that a property should be localized. This
        ///    <see langword='static '/>field is read-only. 
        ///    </para>
        /// </summary>
        public static readonly LocalizableAttribute Yes = new LocalizableAttribute(true);

        /// <summary>
        ///    <para>
        ///       Specifies that a property should not be localized. This
        ///    <see langword='static '/>field is read-only. 
        ///    </para>
        /// </summary>
        public static readonly LocalizableAttribute No = new LocalizableAttribute(false);

        /// <summary>
        ///    <para>
        ///       Specifies the default value, which is <see cref='System.ComponentModel.LocalizableAttribute.No'/> , that is
        ///       a property should not be localized. This <see langword='static '/>field is
        ///       read-only.
        ///    </para>
        /// </summary>
        public static readonly LocalizableAttribute Default = No;

        /// <internalonly/>
        /// <summary>
        /// </summary>
        bool IIsDefaultAttribute.IsDefaultAttribute()
        {
            return IsLocalizable == Default.IsLocalizable;
        }

        public override bool Equals(object obj)
        {
            LocalizableAttribute other = obj as LocalizableAttribute;
            return (other != null) && other.IsLocalizable == _isLocalizable;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
