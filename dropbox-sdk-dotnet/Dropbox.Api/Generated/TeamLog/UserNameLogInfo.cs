// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>User's name logged information</para>
    /// </summary>
    /// <seealso cref="MemberAddNameDetails" />
    /// <seealso cref="MemberChangeNameDetails" />
    public class UserNameLogInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserNameLogInfo> Encoder = new UserNameLogInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserNameLogInfo> Decoder = new UserNameLogInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserNameLogInfo" />
        /// class.</para>
        /// </summary>
        /// <param name="givenName">Given name.</param>
        /// <param name="surname">Surname.</param>
        /// <param name="locale">Locale. Might be missing due to historical data gap.</param>
        public UserNameLogInfo(string givenName,
                               string surname,
                               string locale = null)
        {
            if (givenName == null)
            {
                throw new sys.ArgumentNullException("givenName");
            }

            if (surname == null)
            {
                throw new sys.ArgumentNullException("surname");
            }

            this.GivenName = givenName;
            this.Surname = surname;
            this.Locale = locale;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserNameLogInfo" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UserNameLogInfo()
        {
        }

        /// <summary>
        /// <para>Given name.</para>
        /// </summary>
        public string GivenName { get; protected set; }

        /// <summary>
        /// <para>Surname.</para>
        /// </summary>
        public string Surname { get; protected set; }

        /// <summary>
        /// <para>Locale. Might be missing due to historical data gap.</para>
        /// </summary>
        public string Locale { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserNameLogInfo" />.</para>
        /// </summary>
        private class UserNameLogInfoEncoder : enc.StructEncoder<UserNameLogInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserNameLogInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("given_name", value.GivenName, writer, enc.StringEncoder.Instance);
                WriteProperty("surname", value.Surname, writer, enc.StringEncoder.Instance);
                if (value.Locale != null)
                {
                    WriteProperty("locale", value.Locale, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserNameLogInfo" />.</para>
        /// </summary>
        private class UserNameLogInfoDecoder : enc.StructDecoder<UserNameLogInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserNameLogInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserNameLogInfo Create()
            {
                return new UserNameLogInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserNameLogInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "given_name":
                        value.GivenName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "surname":
                        value.Surname = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "locale":
                        value.Locale = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}