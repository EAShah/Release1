/* 
	Description: This file contains the model database, DB sets and navigational properties 
                 that will be used for the Probation Management System. 
	Author: Elaf Shah/ EAS
	Due date: 27/02/2018
*/

namespace Project._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProbationManagementSystem : DbContext
    {
        // Creation of model database of the Probation Management System.
        public ProbationManagementSystem()
            : base("name=ProbationManagementSystem")
        {
        }

        // Declaration of tables as DB sets of the Probation Management System
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Colleague> Colleagues { get; set; }
        public virtual DbSet<Competency> Competencies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<ExtensionRequest> ExtensionRequests { get; set; }
        public virtual DbSet<ExtensionSubmission> ExtensionSubmissions { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<PerformanceCriterion> PerformanceCriterions { get; set; }
        public virtual DbSet<ProbationaryColleague> ProbationaryColleagues { get; set; }
        public virtual DbSet<ProgressReview> ProgressReviews { get; set; }
        public virtual DbSet<SelfAssessment> SelfAssessments { get; set; }
        public virtual DbSet<SelfAssessmentSubmission> SelfAssessmentSubmissions { get; set; }

        // Method declaring navigational properties of the database model.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.CreatedAssignments)
                .WithRequired(e => e.HRAssigns)
                .HasForeignKey(e => e.HRAssignID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ReceivedAssignment)
                .WithRequired(e => e.LMAssigned)
                .HasForeignKey(e => e.LMAssignID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.InspectionAssignment)
                .WithOptional(e => e.LMInspects)
                .HasForeignKey(e => e.LMInspectID);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ExtensionSubmissions)
                .WithRequired(e => e.LMSubmits)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ExtensionRequests)
                .WithOptional(e => e.HRAudits)
                .HasForeignKey(e => e.HRAuditID);

            modelBuilder.Entity<Colleague>()
                .HasOptional(e => e.ProbationaryColleague)
                .WithRequired(e => e.Colleague);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ApprovedProgressReviews)
                .WithOptional(e => e.DHApproval)
                .HasForeignKey(e => e.DHApprovesID);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.EvaluatedProgressReviews)
                .WithOptional(e => e.HREvaluation)
                .HasForeignKey(e => e.HREvaluatesID);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.CreatedProgressReviews)
                .WithRequired(e => e.LMCreates)
                .HasForeignKey(e => e.LMID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ApprovedSelfAssessments)
                .WithOptional(e => e.DHApprovals)
                .HasForeignKey(e => e.DHApprovesID);

            modelBuilder.Entity<Colleague>()
                .HasMany(e => e.ReviewedSelfAssessments)
                .WithOptional(e => e.HRReviews)
                .HasForeignKey(e => e.HRReviewsID);

            modelBuilder.Entity<Competency>()
                .HasMany(e => e.PerformanceCriterions)
                .WithRequired(e => e.Competency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Colleagues)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExtensionRequest>()
                .HasMany(e => e.ExtensionSubmissions)
                .WithRequired(e => e.ExtensionRequest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Meeting>()
                .HasRequired(e => e.ProgressReviews)
                .WithRequiredPrincipal()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProbationaryColleague>()
                .HasMany(e => e.Assignments)
                .WithRequired(e => e.ProbationaryColleague)
                .HasForeignKey(e => e.PCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProbationaryColleague>()
                .HasMany(e => e.ExtensionSubmissions)
                .WithRequired(e => e.ProbationaryColleague)
                .HasForeignKey(e => e.PCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProbationaryColleague>()
                .HasMany(e => e.ProgressReviews)
                .WithRequired(e => e.ProbationaryColleague)
                .HasForeignKey(e => e.PCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProbationaryColleague>()
                .HasMany(e => e.SelfAssessmentSubmissions)
                .WithRequired(e => e.ProbationaryColleague)
                .HasForeignKey(e => e.PCID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProgressReview>()
                .HasMany(e => e.PerformanceCriterions)
                .WithRequired(e => e.ProgressReview)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProgressReview>()
                .HasMany(e => e.SelfAssessmentSubmissions)
                .WithRequired(e => e.ProgressReview)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SelfAssessment>()
                .HasMany(e => e.SelfAssessmentSubmissions)
                .WithRequired(e => e.SelfAssessment)
                .WillCascadeOnDelete(false);
        }
    }
}
