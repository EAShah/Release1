/* 
	Description: This file declares the class 'SelfAssessment' and its properties
                 for the Probation Management System database.
	Author: Elaf Shah/ EAS
	Due date: 27/02/2018
*/

namespace Project._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    // Creation of the SelfAssessment table as a class.
    [Table("SelfAssessment")]
    public partial class SelfAssessment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SelfAssessment()
        {
            SelfAssessmentSubmissions = new HashSet<SelfAssessmentSubmission>();
        }

        // Declaring attributes of the SelfAssessment table as properties.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AssessmentID { get; set; }

        [StringLength(250)]
        public string PREvalDescription { get; set; }

        [StringLength(250)]
        public string SelfEvaluation { get; set; }

        public int? SAApprovalStatus { get; set; }

        public int? SACompletionStatus { get; set; }

        public int? HRReviewsID { get; set; }

        public int? DHApprovesID { get; set; }

        public virtual Colleague DHApprovals { get; set; }

        public virtual Colleague HRReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelfAssessmentSubmission> SelfAssessmentSubmissions { get; set; }
    }
}
