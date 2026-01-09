import type { TriageStatus } from './triage-status.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdatePatientDto {
  name: string;
  surname: string;
  complaint?: string;
  status?: TriageStatus;
}

export interface PatientDto extends AuditedEntityDto<string> {
  name?: string;
  surname?: string;
  complaint?: string;
  status?: TriageStatus;
  admissionDate?: string;
}
