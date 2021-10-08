using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitfox.Freshworks.Models
{
    public class Params
    {
        /// <summary>
        /// Possible keys:
        /// "users"
        /// "targetable"
        /// "owner"
        /// "creater"
        /// "updater"
        /// "source"
        /// "campaign"
        /// "tasks"
        /// "appointments"
        /// "notes"
        /// "deals"
        /// "sales_accounts"
        /// "territory"
        /// "sales_account"
        /// "territory"
        /// "business_type"
        /// "tasks"
        /// "contacts"
        /// "industry_type"
        /// "child_sales_accounts"
        /// "deal_stage"
        /// "deal_type"
        /// "deal_reason"
        /// "deal_payment_status"
        /// "deal_product"
        /// "currency"
        /// "probability"
        /// "created_at"
        /// "updated_at"
        /// "field_group"
        /// "user"
        /// "users"
        /// "targetable"
        /// "appointment_attendees"
        /// "owner"
        /// "creater"
        /// </summary>
        public List<string> Includes { get; set; } = null;

        /// <summary>
        /// Amount of pages as limit (1 page is 25 items)
        /// </summary>
        public int? Page { get; set; } = null;

        /// <summary>
        /// Limit Amount response containing 
        /// </summary>
        public int? Limit { get; set; } = null;

        /// <summary>
        /// Add params to path
        /// </summary>
        public string AddPath(string path)
        {
            if (Includes != null || Page != null || Limit != null)
            {
                path += "?";
            }

            // Includes
            if (Includes != null)
            {
                path += "include=";
                for (int i=0; i < Includes.Count; i++)
                {
                    string include = Includes[i];
                    if (i+1 < Includes.Count)
                    {
                        path += $"{include},";
                    }
                    else
                    {
                        path += $"{include}";
                    }
                }
            }

            // Page
            if (Page != null)
            {
                if(Includes != null)
                {
                    path += "&";
                }

                path += $"page={Page}";
            }

            // Limit
            if (Limit != null)
            {
                if(Includes != null || Page != null)
                {
                    path += "&";
                }

                path += $"limit={Limit}";
            }

            return path;
        }

    }
}
