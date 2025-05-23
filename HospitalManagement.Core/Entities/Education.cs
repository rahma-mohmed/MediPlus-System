﻿namespace HospitalSystem.Core.Entities
{
    public class Education
        {
            [Key]
            public string Id { get; set; }=Guid.NewGuid().ToString();
            [Required]
            public string Institution { get; set; }
            [Required]
            public string Degree { get; set; }
            [Required]
            public string? FieldOfStudy { get; set; }
            public int StartYear { get; set; }
            public int EndYear { get; set; }
            public string DoctorId { get; set; }
            [ForeignKey(nameof(DoctorId))]
            public virtual Doctor? Doctor { get; set; }
        }

}
