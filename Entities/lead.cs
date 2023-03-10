using System;

namespace HypoplusToDwhExporter.Entities
{
#pragma warning disable IDE1006 // Naming Styles
    public class lead
    {
        public string create_user { get; set; }
        public string cs_name { get; set; }
        public string cu_comment_hypo_plus { get; set; }
        public string cu_comment_lender { get; set; }
        public string cu_email { get; set; }
        public string cu_firstname { get; set; }
        public string cu_lastname { get; set; }
        public string cu_street { get; set; }
        public string cu_zip { get; set; }
        public string cu_city { get; set; }
        public string cu_phone_mobile { get; set; }
        public string cu_title { get; set; }
        public string ev_strategy { get; set; }
        public string lead_cl_comment { get; set; }
        public string lead_comment { get; set; }
        public string lead_id { get; set; }
        public string lead_owner { get; set; }
        public string lender_id { get; set; }
        public string lender_name { get; set; }
        public string lender_title { get; set; }
        public string mo_productname { get; set; }
        public string mr_property_house_number { get; set; }
        public string mr_property_street { get; set; }
        public string mr_property_zip { get; set; }
        //public string mr_property_canton_code { get; set; }
        //public string mr_property_town_seo_name { get; set; }
        public string request_id { get; set; }
        public string update_user { get; set; }
        public string lead_deal_comment { get; set; }
        public string ev_region_name { get; set; }
        public string user_archived { get; set; }
        public string user_assigned { get; set; }
        public string user_closed { get; set; }
        public string user_contacted { get; set; }
        public string user_deal_signed { get; set; }
        public string user_forwarded { get; set; }
        public string user_reopened { get; set; }
        public string mr_app_context { get; set; }
        public string mr_app_id { get; set; }
        public string mr_referrer { get; set; }
        public string mr_remortgage_previous_lender { get; set; }
        public string lead_lender_internal_id { get; set; }
        public string session_id { get; set; }
        public string user_contacted_hypo_plus { get; set; }
        public string mo_tr_four_billing_reference { get; set; }
        public string mo_tr_one_billing_reference { get; set; }
        public string mo_tr_three_billing_reference { get; set; }
        public string mo_tr_two_billing_reference { get; set; }
        public string user_dossier_completed { get; set; }
        public string mr_comment_income_sub_other { get; set; }
        public string mr_comment_mortgage_total { get; set; }
        public string mr_comment_property_value { get; set; }
        public string ev_region_comment { get; set; }
        public string user_binding_conditions_offered { get; set; }
        public string mr_lang { get; set; }
        public string user_dossier_sent_to_lender { get; set; }
        //public string mr_activity_guid { get; set; }
        //public string mr_parent_activity_guid { get; set; }
        public string lead_cl_learning_comment { get; set; }
        public DateTime? create_timestamp { get; set; }
        public DateTime? mr_new_start_date { get; set; }
        public DateTime? ts_assigned { get; set; }
        public DateTime? ts_closed { get; set; }
        public DateTime? ts_contacted { get; set; }
        public DateTime? ts_deal_signed { get; set; }
        public DateTime? ts_forwarded { get; set; }
        public DateTime? ts_lead_payout { get; set; }
        public DateTime? ts_reopenend { get; set; }
        public DateTime? ts_submitted { get; set; }
        public DateTime? update_timestamp { get; set; }
        public DateTime? ts_archived { get; set; }
        public DateTime? ts_reopened { get; set; }
        public DateTime? ts_commission_payout { get; set; }
        public DateTime? ts_contacted_hypo_plus { get; set; }
        public DateTime? mo_tr_four_ts_payout { get; set; }
        public DateTime? mo_tr_one_ts_payout { get; set; }
        public DateTime? mo_tr_three_ts_payout { get; set; }
        public DateTime? mo_tr_two_ts_payout { get; set; }
        public DateTime? ts_dossier_completed { get; set; }
        public DateTime? ts_binding_conditions_offered { get; set; }
        public DateTime? ts_dossier_sent_to_lender { get; set; }
        public DateTime? mr_tranche1start_date { get; set; }
        public DateTime? mr_tranche2start_date { get; set; }
        public DateTime? mr_tranche3start_date { get; set; }
        public DateTime? mr_tranche4start_date { get; set; }
        public bool? lead_own_customer { get; set; }
        public bool? mr_tranche_needed { get; set; }
        public bool? mr_use_sec_available { get; set; }
        public int? id { get; set; }
        public int? customer { get; set; }
        public int? ev_affordability_amortisation_cost { get; set; }
        public int? ev_affordability_first_mortgage_cost { get; set; }
        public int? ev_affordability_first_mortgage_size { get; set; }
        public int? ev_affordability_maintenance_cost { get; set; }
        public int? ev_affordability_second_mortgage_cost { get; set; }
        public int? ev_affordability_second_mortgage_size { get; set; }
        public int? ev_affordability_total_cost { get; set; }
        public int? ev_total_equity { get; set; }
        public int? ev_total_income { get; set; }
        public int? ev_total_mortgage_size { get; set; }
        public int? ev_total_property_value { get; set; }
        public int? ev_total_securities { get; set; }
        public int? lead_cl_reason { get; set; }
        public int? lead_cl_tr_one_category { get; set; }
        public int? lead_cl_tr_two_category { get; set; }
        public int? lead_status { get; set; }
        public int? lead_tr_one_size_total { get; set; }
        public int? lead_tr_two_size_total { get; set; }
        public int? mo_amortisation_cost { get; set; }
        public int? mo_effective_size { get; set; }
        public int? mo_effective_total_cost { get; set; }
        public int? mo_effective_total_mortgage_cost { get; set; }
        public int? mo_maintenance_cost { get; set; }
        public int? mo_tr_one_category { get; set; }
        public int? mo_tr_one_effective_tranche_cost { get; set; }
        public int? mo_tr_one_size_first_mortgage { get; set; }
        public int? mo_tr_one_size_second_mortgage { get; set; }
        public int? mo_tr_one_size_total { get; set; }
        public int? mo_tr_two_category { get; set; }
        public int? mo_tr_two_effective_tranche_cost { get; set; }
        public int? mo_tr_two_size_first_mortgage { get; set; }
        public int? mo_tr_two_size_second_mortgage { get; set; }
        public int? mo_tr_two_size_total { get; set; }
        public int? mr_cost_sub_interest { get; set; }
        public int? mr_cost_sub_other { get; set; }
        public int? mr_cost_sub_other_mortgage { get; set; }
        public int? mr_cost_sub_other_object_affordability { get; set; }
        public int? mr_cost_total { get; set; }
        public int? mr_customer_year_of_birth { get; set; }
        public int? mr_equity_sub_anticipatory_succession { get; set; }
        public int? mr_equity_sub_cash { get; set; }
        public int? mr_equity_sub_loan { get; set; }
        public int? mr_equity_sub_pension2 { get; set; }
        public int? mr_equity_sub_pension3 { get; set; }
        public int? mr_equity_total { get; set; }
        public int? mr_income_sub_basic { get; set; }
        public int? mr_income_sub_bonus { get; set; }
        public int? mr_income_sub_other { get; set; }
        public int? mr_income_sub_part_basic { get; set; }
        public int? mr_income_sub_part_bonus { get; set; }
        public int? mr_income_total { get; set; }
        public int? mr_mortgage_total { get; set; }
        public int? mr_property_living_space { get; set; }
        public int? mr_property_plot_size { get; set; }
        public int? mr_property_value { get; set; }
        public int? mr_property_value_origin { get; set; }
        public int? mr_property_value_year { get; set; }
        //public int? mr_property_town_id { get; set; }
        public int? mr_request_type { get; set; }
        public int? mr_sec_sub_life_insurance { get; set; }
        public int? mr_sec_sub_pension2 { get; set; }
        public int? mr_sec_sub_pension3 { get; set; }
        public int? mr_sec_sub_port_bonds { get; set; }
        public int? mr_sec_sub_port_funds { get; set; }
        public int? mr_sec_sub_port_shares { get; set; }
        public int? mr_sec_total { get; set; }
        public int? version { get; set; }
        public int? mo_tr_four_category { get; set; }
        public int? mo_tr_four_size_total { get; set; }
        public int? mo_tr_three_category { get; set; }
        public int? mo_tr_three_size_total { get; set; }
        public int? mr_property_type { get; set; }
        public int? lead_num_concurrent_lenders { get; set; }
        public int? ev_affordability_amortisation_size { get; set; }
        public int? mr_property_usage_type { get; set; }
        public int? mo_tr_four_commission { get; set; }
        public int? mo_tr_one_commission { get; set; }
        public int? mo_tr_three_commission { get; set; }
        public int? mo_tr_two_commission { get; set; }
        public int? mr_sec_sub_portfolio { get; set; }
        public int? mr_request_sub_type { get; set; }
        public int? mr_customer_year_of_birth_part { get; set; }
        public int? mr_previous_mortgage_total { get; set; }
        public int? mr_previous_pension2equity { get; set; }
        public int? mr_income_sub_monthly_obligations { get; set; }
        public int? mr_sec_available_pension2 { get; set; }
        public int? mr_sec_available_pension3a { get; set; }
        public int? mr_sec_available_pension3b { get; set; }
        public int? mr_sec_available_portfolio { get; set; }
        public int? mr_tranche1vol { get; set; }
        public int? mr_tranche2vol { get; set; }
        public int? mr_tranche3vol { get; set; }
        public int? mr_tranche4vol { get; set; }
        public double? lead_cl_tr_one_maturity { get; set; }
        public double? lead_cl_tr_two_maturity { get; set; }
        public double? mo_tr_one_maturity { get; set; }
        public double? mo_tr_two_maturity { get; set; }
        public double? mr_property_condition { get; set; }
        public double? mr_property_location { get; set; }
        public double? mr_property_quality { get; set; }
        public double? mo_tr_four_maturity { get; set; }
        public double? mo_tr_three_maturity { get; set; }
        public float? cs_base_rate_premium { get; set; }
        public float? ev_affordability_first_mortgage_rate { get; set; }
        public float? ev_affordability_rate { get; set; }
        public float? ev_affordability_second_mortgage_rate { get; set; }
        public float? ev_loan_to_value_brutto_ratio { get; set; }
        public float? ev_loan_to_value_netto_ratio { get; set; }
        public float? ev_loan_to_value_ratio_without_securities_and_pension_equity { get; set; }
        public float? ev_loan_to_value_ratio_without_securities { get; set; }
        public float? ev_loan_to_value_ratio { get; set; }
        public float? mo_effective_rate_total { get; set; }
        public float? mo_tr_one_base_rate_first { get; set; }
        public float? mo_tr_one_base_rate_premium_customer_segment { get; set; }
        public float? mo_tr_one_base_rate_premium_second_mortgage { get; set; }
        public float? mo_tr_one_effective_rate_first { get; set; }
        public float? mo_tr_one_effective_rate_second { get; set; }
        public float? mo_tr_one_effective_rate_total { get; set; }
        public float? mo_tr_two_base_rate_first { get; set; }
        public float? mo_tr_two_base_rate_premium_customer_segment { get; set; }
        public float? mo_tr_two_base_rate_premium_second_mortgage { get; set; }
        public float? mo_tr_two_effective_rate_first { get; set; }
        public float? mo_tr_two_effective_rate_second { get; set; }
        public float? mo_tr_two_effective_rate_total { get; set; }
    }

#pragma warning restore IDE1006 // Naming Styles
}
