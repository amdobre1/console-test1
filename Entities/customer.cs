using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HypoplusToDwhExporter.Entities
{
#pragma warning disable IDE1006 // Naming Styles
    public class customer
    {
        public string activation_challenge { get; set; }
        public string comment_hypo_plus { get; set; }
        public string comment_lender { get; set; }
        public string create_user { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string zip { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string phone_mobile { get; set; }
        public string title { get; set; }
        public string update_user { get; set; }
        public string phone_best_time { get; set; }
        public string filter_reason { get; set; }
        public string app_context { get; set; }
        public string app_id { get; set; }
        public string lender_signed { get; set; }
        public string referrer_url { get; set; }
        public string relationship_manager { get; set; }
        public string comment_deal_billing { get; set; }
        public string deal_billing_reference { get; set; }
        public string customer_origin { get; set; }
        public string track_first_session_id { get; set; }
        public string firstname_part { get; set; }
        public string lastname_part { get; set; }
        public string title_part { get; set; }
        public string education { get; set; }
        public string education_part { get; set; }
        public string comment_net_worth { get; set; }
        public string deal_referrer_billing_reference { get; set; }
        public string lang { get; set; }
        public string priority { get; set; }
        public string external_id { get; set; }
        public string nationality { get; set; }
        public string nationality_part { get; set; }
        public string deal_acc_mod_comment { get; set; }
        public string deal_acc_reference { get; set; }
        public string deal_acc_action { get; set; }
        public string deal_acc_mod_owner { get; set; }
        public string pdca_check_category { get; set; }
        public string uuid { get; set; }
        public string deal_commission_user { get; set; }
        public string phone_home { get; set; }
        public string phone_work { get; set; }
        public DateTime? create_timestamp { get; set; }
        public DateTime? update_timestamp { get; set; }
        public DateTime? mr_new_start_date { get; set; }
        public DateTime? next_action_date { get; set; }
        public DateTime? deal_acc_mod_date { get; set; }
        public DateTime? deal_acc_payment_date { get; set; }
        public DateTime? deal_commission_timestamp { get; set; }
        public string comment_hypo_plus_internal { get; set; }
        public string comment_hypo_plus_to_lender { get; set; }
        public string comment_next_action { get; set; }
        public string pdca_check_description { get; set; }
        public bool? bank_secret_accepted { get; set; }
        public bool? terms_accepted { get; set; }
        public bool? best_case { get; set; }
        public bool? hands_off { get; set; }
        public int? id { get; set; }
        public int? referrer { get; set; }
        public int? version { get; set; }
        public int? category { get; set; }
        [Column("customer_status"), JsonIgnore]
        public int? customer_status_id { get; set; }
        [ForeignKey("customer_status_id")]
        public customer_status customer_status { get; set; }
        public int? property_type { get; set; }
        public int? request_type { get; set; }
        public int? customer_category { get; set; }
        public int? deal_commission { get; set; }
        public int? customer_group { get; set; }
        public int? deal_probability { get; set; }
        public int? deal_size { get; set; }
        public int? employment_type { get; set; }
        public int? employment_type_part { get; set; }
        public int? civil_status { get; set; }
        public int? civil_status_part { get; set; }
        public int? net_pension2 { get; set; }
        public int? net_worth { get; set; }
        public int? deal_referrer_commission { get; set; }
        public int? priority_ignore_value { get; set; }
        public int? priority_value { get; set; }
        public int? deal_commissionvat { get; set; }
        public int? deal_acc_mod_difference { get; set; }
        public int? contact_rating { get; set; }
        public int? deal_commission_when_signed { get; set; }
        public int? expected_deal_commission { get; set; }
        public float? conversion_potential_factor { get; set; }
    }
#pragma warning restore IDE1006 // Naming Styles
}
