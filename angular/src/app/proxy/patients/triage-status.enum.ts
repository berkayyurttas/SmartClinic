import { mapEnumToOptions } from '@abp/ng.core';

export enum TriageStatus {
  Green = 1,
  Yellow = 2,
  Red = 3,
}

export const triageStatusOptions = mapEnumToOptions(TriageStatus);
