﻿using System.Text.Json.Serialization;
using LiveVox.NET.Converter;
using LiveVox.NET.Models.Campaign.Enumerations;
using LiveVox.NET.Models.Contact.Enumerations;
using LiveVox.NET.Models.Contact.Requests.Contact_Groups;
using LiveVox.NET.Models.Contact.Requests.ContactGroups;
using LiveVox.NET.Models.Contact.Requests.Contacts;
using LiveVox.NET.Models.Contact.Requests.CustomField;
using LiveVox.NET.Models.Contact.Responses.Contact_Groups;
using LiveVox.NET.Models.Contact.Responses.ContactGroups;
using LiveVox.NET.Models.Contact.Responses.ContactNotes;
using LiveVox.NET.Models.Contact.Responses.Contacts;
using LiveVox.NET.Models.Contact.Responses.CustomField;
using LiveVox.NET.Models.Campaign.Requests;
using LiveVox.NET.Models.Campaign.Responses;
using LiveVox.NET.Models.Compliance.Enumerations;
using LiveVox.NET.Models.Compliance.Requests.ComplianceCheck;
using LiveVox.NET.Models.Compliance.Requests.DialingProfiles;
using LiveVox.NET.Models.Compliance.Responses.ComplianceCheck;
using LiveVox.NET.Models.Compliance.Responses.DialingProfiles;
using LiveVox.NET.Models.Session;
using DayOfWeek = System.DayOfWeek;

namespace LiveVox.NET.Models
{
    [JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase, GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(AnsweringMachineOption))]
    [JsonSerializable(typeof(CampaignType))]
    [JsonSerializable(typeof(CampaignStatus))]
    [JsonSerializable(typeof(CampaignState))]
    [JsonSerializable(typeof(ScrubOption))]
    [JsonSerializable(typeof(VoiceTalent))]
    [JsonSerializable(typeof(SessionLoginRequest))]
    [JsonSerializable(typeof(SessionLoginResponse))]
    [JsonSerializable(typeof(DialBlockOption))]
    [JsonSerializable(typeof(CreateContactRequest))]
    [JsonSerializable(typeof(CreateContactResponse))]
    [JsonSerializable(typeof(BulkCreateContactRequest))]
    [JsonSerializable(typeof(BulkCreateOrUpdateContactResponse))]
    [JsonSerializable(typeof(SearchContactsRequest))]
    [JsonSerializable(typeof(ListContactsResponse))]
    [JsonSerializable(typeof(ReadContactResponse))]
    [JsonSerializable(typeof(UpdateContactRequest))]
    [JsonSerializable(typeof(BulkUpdateContactRequest))]
    [JsonSerializable(typeof(CreateContactGroupRequest))]
    [JsonSerializable(typeof(CreateContactGroupResponse))]
    [JsonSerializable(typeof(ListContactGroupResponse))]
    [JsonSerializable(typeof(ReadContactGroupResponse))]
    [JsonSerializable(typeof(UpdateContactGroupRequest))]
    [JsonSerializable(typeof(ReadContactNoteResponse))]
    [JsonSerializable(typeof(RuleOperator))]
    [JsonSerializable(typeof(ExportableFieldBulkDownload))]
    [JsonSerializable(typeof(BulkContactDownloadRequest))]
    [JsonSerializable(typeof(UpdateContactDndRequest))]
    [JsonSerializable(typeof(ListCustomFieldResponse))]
    [JsonSerializable(typeof(ReadCustomFieldResponse))]
    [JsonSerializable(typeof(UpdateCustomFieldRequest))]
    [JsonSerializable(typeof(ContactDetailCustomField))]
    [JsonSerializable(typeof(CustomFieldDataType))]
    [JsonSerializable(typeof(SearchContactsResponse))]
    [JsonSerializable(typeof(ConditionType))]
    [JsonSerializable(typeof(SearchConditionContactField))]
    [JsonSerializable(typeof(SearchContactsSortField))]
    [JsonSerializable(typeof(SortOrder))]
    [JsonSerializable(typeof(ListAccountsResponse))]
    [JsonSerializable(typeof(AppendCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignRequest))]
    [JsonSerializable(typeof(CreateCampaignResponse))]
    [JsonSerializable(typeof(DeactivateCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignRequest))]
    [JsonSerializable(typeof(SearchCampaignResponse))]
    [JsonSerializable(typeof(SearchFinishedCallRequest))]
    [JsonSerializable(typeof(SearchFinishedCallResponse))]
    [JsonSerializable(typeof(GetCampaignListInfoRequest))]
    [JsonSerializable(typeof(GetCampaignListInfoResponse))]
    [JsonSerializable(typeof(ListCampaignRequest))]
    [JsonSerializable(typeof(ListCampaingnResponse))]
    [JsonSerializable(typeof(ListCampaignTransactionsRequest))]
    [JsonSerializable(typeof(ListCampaignTransactionsResponse))]
    [JsonSerializable(typeof(ReadCampaignRequest))]
    [JsonSerializable(typeof(ReadCampaignResponse))]
    [JsonSerializable(typeof(UpdateCampaignRequest))]
    [JsonSerializable(typeof(UpdateCampaignStateRequest))]
    [JsonSerializable(typeof(ZipAreaMatchType))]
    [JsonSerializable(typeof(DayOfWeek))]
    [JsonSerializable(typeof(IsComplianceBlockedRequest))]
    [JsonSerializable(typeof(IsComplianceBlockedResponse))]
    [JsonSerializable(typeof(ZipAreaMatchRequest))]
    [JsonSerializable(typeof(ZipAreaMatchResponse))]
    [JsonSerializable(typeof(CreateDialingPolicyRequest))]
    [JsonSerializable(typeof(CreateDialingPolicyResponse))]
    [JsonSerializable(typeof(CreateDialingProfileRequest))]
    [JsonSerializable(typeof(CreateDialingProfileResponse))]
    [JsonSerializable(typeof(DeleteDialingPolicyRequest))]
    [JsonSerializable(typeof(DeleteDialingProfileRequest))]
    [JsonSerializable(typeof(GetDialingProfileListInfoRequest))]
    [JsonSerializable(typeof(GetDialingProfileListInfoResponse))]
    [JsonSerializable(typeof(ListDialingProfileRequest))]
    [JsonSerializable(typeof(ListDialingProfileResponse))]
    [JsonSerializable(typeof(ReadDialingProfileRequest))]
    [JsonSerializable(typeof(ReadDialingProfileResponse))]
    [JsonSerializable(typeof(UpdateDialingPolicyRequest))]
    [JsonSerializable(typeof(UpdateDialingProfileRequest))]
    [JsonSerializable(typeof(UpdateDialingProfileAddServiceRequest))]
    [JsonSerializable(typeof(DateTimeOffsetToUtcMillisecondStringConverter))]
    public partial class LiveVoxSerializerContext : JsonSerializerContext
    {
        // The source generator will fill in the necessary code here.
    }
}
