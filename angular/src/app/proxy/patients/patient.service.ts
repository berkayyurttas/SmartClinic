import type { CreateUpdatePatientDto, PatientDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable, inject } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class PatientService {
  private restService = inject(RestService);
  apiName = 'Default';
  

  create = (input: CreateUpdatePatientDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PatientDto>({
      method: 'POST',
      url: '/api/app/patient',
      body: input,
    },
    { apiName: this.apiName,...config });
  

  delete = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/patient/${id}`,
    },
    { apiName: this.apiName,...config });
  

  get = (id: string, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PatientDto>({
      method: 'GET',
      url: `/api/app/patient/${id}`,
    },
    { apiName: this.apiName,...config });
  

  getList = (input: PagedAndSortedResultRequestDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<PatientDto>>({
      method: 'GET',
      url: '/api/app/patient',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName,...config });
  

  update = (id: string, input: CreateUpdatePatientDto, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PatientDto>({
      method: 'PUT',
      url: `/api/app/patient/${id}`,
      body: input,
    },
    { apiName: this.apiName,...config });
}