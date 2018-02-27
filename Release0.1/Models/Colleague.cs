/* 
	Description: This file declares the class 'Colleague' and its properties 
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

    // Creation of the Colleague table as a class.
    [Table("Colleague")]
    public partial class Colleague
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colleague()
        {
            CreatedAssignments = new HashSet<Assignment>();
            ReceivedAssignment = new HashSet<Assignment>();
            InspectionAssignment = new HashSet<Assignment>();
            ExtensionSubmissions = new HashSet<ExtensionSubmission>();
            ExtensionRequests = new HashSet<ExtensionRequest>();
            ApprovedProgressReviews = new HashSet<ProgressReview>();
            EvaluatedProgressReviews = new HashSet<ProgressReview>();
            CreatedProgressReviews = new HashSet<ProgressReview>();
            ApprovedSelfAssessments = new HashSet<SelfAssessment>();
            ReviewedSelfAssessments = new HashSet<SelfAssessment>();
        }

        // Declaring attributes of the Colleague table as properties.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ColleagueID { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOB { get; set; }

        [Required]
        [StringLength(50)]
        public string EmploymentType { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string MobileNumber { get; set; }

        [StringLength(20)]
        public string HomeNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string ColleagueType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SAHRAReviewDate { get; set; }

        public int? SAHRAReviewDecision { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SADHApproveDate { get; set; }

        public int DepartmentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> CreatedAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> ReceivedAssignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> InspectionAssignment { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtensionSubmission> ExtensionSubmissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtensionRequest> ExtensionRequests { get; set; }

        public virtual ProbationaryColleague ProbationaryColleague { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressReview> ApprovedProgressReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressReview> EvaluatedProgressReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgressReview> CreatedProgressReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelfAssessment> ApprovedSelfAssessments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelfAssessment> ReviewedSelfAssessments { get; set; }
    }
}
