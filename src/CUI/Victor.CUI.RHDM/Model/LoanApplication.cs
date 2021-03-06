﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Victor.CUI.RHDM.KIE.Model;
//
//    var loanApplication = LoanApplication.FromJson(jsonString);

namespace Victor.CUI.RHDM.KIE.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LoanApplication
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("result")]
        public LoanApplicationResult Result { get; set; }
    }

    public partial class LoanApplicationResult
    {
        [JsonProperty("execution-results")]
        public LoanApplicationExecutionResults ExecutionResults { get; set; }
    }

    public partial class LoanApplicationExecutionResults
    {
        [JsonProperty("results")]
        public LoanApplicationResultElement[] Results { get; set; }

        [JsonProperty("facts")]
        public LoanApplicationFact[] Facts { get; set; }
    }

    public partial class LoanApplicationFact
    {
        [JsonProperty("value")]
        public LoanApplicationFactValue Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public partial class LoanApplicationFactValue
    {
        [JsonProperty("org.drools.core.common.DefaultFactHandle")]
        public LoanApplicationOrgDroolsCoreCommonDefaultFactHandle OrgDroolsCoreCommonDefaultFactHandle { get; set; }
    }

    public partial class LoanApplicationOrgDroolsCoreCommonDefaultFactHandle
    {
        [JsonProperty("external-form")]
        public string ExternalForm { get; set; }
    }

    public partial class LoanApplicationResultElement
    {
        [JsonProperty("value")]
        public LoanApplicationValueUnion Value { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public partial class LoanApplicationValueElement
    {
        [JsonProperty("com.redhat.demos.dm.loan.model.Applicant", NullValueHandling = NullValueHandling.Ignore)]
        public LoanApplicationComRedhatDemosDmLoanModelApplicant ComRedhatDemosDmLoanModelApplicant { get; set; }

        [JsonProperty("com.redhat.demos.dm.loan.model.Loan", NullValueHandling = NullValueHandling.Ignore)]
        public LoanApplicationComRedhatDemosDmLoanModelLoan ComRedhatDemosDmLoanModelLoan { get; set; }

        [JsonProperty("com.redhat.demos.dm.loan.model.Recommendation", NullValueHandling = NullValueHandling.Ignore)]
        public LoanApplicationComRedhatDemosDmLoanModelRecommendation ComRedhatDemosDmLoanModelRecommendation { get; set; }
    }

    public partial class LoanApplicationComRedhatDemosDmLoanModelApplicant
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creditScore")]
        public long CreditScore { get; set; }
    }

    public partial class LoanApplicationComRedhatDemosDmLoanModelLoan
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("interestRate")]
        public long InterestRate { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public partial class LoanApplicationComRedhatDemosDmLoanModelRecommendation
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class LoanApplicationPurpleValue
    {
        [JsonProperty("com.redhat.demos.dm.loan.model.Loan", NullValueHandling = NullValueHandling.Ignore)]
        public LoanApplicationComRedhatDemosDmLoanModelLoan ComRedhatDemosDmLoanModelLoan { get; set; }

        [JsonProperty("com.redhat.demos.dm.loan.model.Applicant", NullValueHandling = NullValueHandling.Ignore)]
        public LoanApplicationComRedhatDemosDmLoanModelApplicant ComRedhatDemosDmLoanModelApplicant { get; set; }
    }

    public partial struct LoanApplicationValueUnion
    {
        public LoanApplicationPurpleValue PurpleValue;
        public LoanApplicationValueElement[] ValueElementArray;

        public static implicit operator LoanApplicationValueUnion(LoanApplicationPurpleValue PurpleValue) => new LoanApplicationValueUnion { PurpleValue = PurpleValue };
        public static implicit operator LoanApplicationValueUnion(LoanApplicationValueElement[] ValueElementArray) => new LoanApplicationValueUnion { ValueElementArray = ValueElementArray };
    }

    public partial class LoanApplication
    {
        public static LoanApplication FromJson(string json) => JsonConvert.DeserializeObject<LoanApplication>(json, Victor.CUI.RHDM.KIE.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LoanApplication self) => JsonConvert.SerializeObject(self, Victor.CUI.RHDM.KIE.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ValueUnionConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ValueUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LoanApplicationValueUnion) || t == typeof(LoanApplicationValueUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LoanApplicationPurpleValue>(reader);
                    return new LoanApplicationValueUnion { PurpleValue = objectValue };
                case JsonToken.StartArray:
                    var arrayValue = serializer.Deserialize<LoanApplicationValueElement[]>(reader);
                    return new LoanApplicationValueUnion { ValueElementArray = arrayValue };
            }
            throw new Exception("Cannot unmarshal type ValueUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LoanApplicationValueUnion)untypedValue;
            if (value.ValueElementArray != null)
            {
                serializer.Serialize(writer, value.ValueElementArray);
                return;
            }
            if (value.PurpleValue != null)
            {
                serializer.Serialize(writer, value.PurpleValue);
                return;
            }
            throw new Exception("Cannot marshal type ValueUnion");
        }

        public static readonly ValueUnionConverter Singleton = new ValueUnionConverter();
    }
}
