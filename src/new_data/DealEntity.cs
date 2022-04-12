using Bitfox.Freshworks.Attributes;
using Bitfox.Freshworks.EndpointFilters;
using Bitfox.Freshworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks
{
    [EndpointName("/api/deals")]
    public class DealEntity : Includes, IHasInsert, IHasUpdate, IHasClone, IHasView, IHasAllView<DealEntity>, IHasDelete, IHasDeleteBulk, IHasForget, IHasFields, IHasFilters, IHasFilteredSearch, IHasUniqueID, IHasDeals
    {
        public List<DealEntity> deals { get; set; }
        //public class Meta
        //{
        //    public int total_pages { get; set; }
        //    public int total { get; set; }
        //}

        public long id { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public string base_currency_amount { get; set; }
        public string expected_close { get; set; }
        public object closed_date { get; set; }
        public DateTime stage_updated_time { get; set; }
        public Custom_Field custom_field { get; set; }
        public int probability { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
        public long deal_pipeline_id { get; set; }
        public long deal_stage_id { get; set; }
        public int age { get; set; }
        public Links links { get; set; }
        public string recent_note { get; set; }
        public object completed_sales_sequences { get; set; }
        public object active_sales_sequences { get; set; }
        public object web_form_id { get; set; }
        public DateTime? upcoming_activities_time { get; set; }
        public Collaboration collaboration { get; set; }
        public DateTime last_assigned_at { get; set; }
        public object[] tags { get; set; }
        public string last_contacted_sales_activity_mode { get; set; }
        public DateTime? last_contacted_via_sales_activity { get; set; }
        public string expected_deal_value { get; set; }
        public Deal_Freddy_Metrics deal_freddy_metrics { get; set; }
        public bool is_deleted { get; set; }
        public object team_user_ids { get; set; }
        public object avatar { get; set; }
        public Fc_Widget_Collaboration fc_widget_collaboration { get; set; }
        public int? forecast_category { get; set; }
        public string deal_tag { get; set; }
        public int deal_prediction { get; set; }
        public int deal_score { get; set; }
        public DateTime? deal_prediction_last_updated_at { get; set; }
        public object freddy_forecast_metrics { get; set; }
        public object last_deal_prediction { get; set; }
        public int? rotten_days { get; set; }
        public bool has_products { get; set; }
        public object products { get; set; }
        public long? ID { get; set; }
        
        public Meta Meta { get; set; }
        public List<DealEntity> Items { get; set; }
        public List<long> SelectedIDs { get; set; }
        public bool? DeleteAssociatedContactDeals { get; set; }

        public List<Filter> Filters { get; set; }

        public class Custom_Field
        {
            public string cf_bronsource { get; set; }
            public object cf_lost_to { get; set; }
            public string cf_region { get; set; }
        }

        public class Links
        {
            public string conversations { get; set; }
            public string document_associations { get; set; }
            public string notes { get; set; }
            public string tasks { get; set; }
            public string appointments { get; set; }
        }

        public class Collaboration
        {
        }

        public class Deal_Freddy_Metrics
        {
            public string deal_tag { get; set; }
            public int deal_score { get; set; }
            public float interpretability_id { get; set; }
            public float interpretability_value { get; set; }
            public string score_delta { get; set; }
            public int score_delta_period { get; set; }
            public object last_7_days_deal_scores { get; set; }
            public string last_updated { get; set; }
            public string nba { get; set; }
            public string cta { get; set; }
        }

        public class Fc_Widget_Collaboration
        {
            public string convo_token { get; set; }
            public string auth_token { get; set; }
            public string encoded_jwt_token { get; set; }
        }

    }
}
