﻿//using Models.DatabaseModels.VehicleRegistration.Core;
using Models.DatabaseModels.PermitIssuance.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DatabaseModels.Biometric
{
    public class BiometricVerification : BaseModel
    {
        [Key]
        public long BiometricVerificationId { get; set; }

        [ForeignKey("Application")]
        public long ApplicationId { get; set; }
        public virtual PermitIssueApplication Application { get; set; }
        public string PersonCNIC { get; set; }

        [ForeignKey("Person")]
        public long? PersonId { get; set; }
        public virtual EPRSPerson Person { get; set; }

        public bool IsBuyer { get; set; }
        public bool IsRep { get; set; }

        [ForeignKey("NadraFranchise")]
        public long? NadraFranchiseId { get; set; }
        public virtual NadraFranchise NadraFranchise { get; set; }

        public long? NadraTransId { get; set; }
        public bool? IsVerified { get; set; }
        public bool? IsExpired { get; set; }
        public DateTime? VerificationReportedOn { get; set; }
        public DateTime? VerificationExpiry { get; set; }
    }
}