//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TvProgramGuideApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChannelSchedule
    {
        public string ChannelCategoryId { get; set; }
        public string ChannelId { get; set; }
        public System.DateTime BroadcastDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public string ProgramId { get; set; }
    
        public virtual Channels pg_Channels { get; set; }
    }
}
