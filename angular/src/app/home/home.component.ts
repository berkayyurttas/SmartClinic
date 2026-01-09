import { Component, OnInit, OnDestroy } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ThemeSharedModule } from '@abp/ng.theme.shared'; 
import { PatientService, PatientDto } from '../proxy/patients';
import { interval, Subscription } from 'rxjs';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, ThemeSharedModule],
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit, OnDestroy {
  patients: PatientDto[] = [];
  filteredPatients: PatientDto[] = []; 
  
  // MODAL KONTROLLERİ
  isModalOpen = false;        // Yeni Hasta Kayıt Modalı
  isDetailModalOpen = false;  // Hasta Detay Modalı (YENİ)
  selectedPatient: any = null; // Seçilen Hastanın Bilgisi (YENİ)
  
  patientForm: FormGroup;
  private timerSubscription: Subscription;

  constructor(private patientService: PatientService, private fb: FormBuilder) {}

  ngOnInit() {
    this.loadPatients();
    this.buildForm();
    // 30 saniyede bir otomatik yenileme
    this.timerSubscription = interval(30000).subscribe(() => this.loadPatients());
  }

  ngOnDestroy() {
    if (this.timerSubscription) this.timerSubscription.unsubscribe();
  }

  loadPatients() {
    this.patientService.getList({ maxResultCount: 100 }).subscribe((result) => {
      this.patients = result.items;
      this.filteredPatients = result.items; 
    });
  }

  // ARAMA FONKSİYONU
  onSearch(event: any) {
    const value = (event.target as HTMLInputElement).value.toLowerCase();
    this.filteredPatients = this.patients.filter(p => 
      ((p.name || '') + ' ' + (p.surname || '')).toLowerCase().includes(value)
    );
  }

  // DETAY MODALINI AÇAN FONKSİYON (YENİ)
  openDetail(patient: any) {
    this.selectedPatient = patient;
    this.isDetailModalOpen = true;
  }

  // İSTATİSTİK HESAPLAMA
  getCount(status: number): number {
    return this.patients.filter(p => (p.status || (p as any).Status) === status).length;
  }

  buildForm() {
    this.patientForm = this.fb.group({
      name: ['', Validators.required],
      surname: ['', Validators.required],
      complaint: ['', Validators.required],
      status: [3, Validators.required],
    });
  }

  createPatient() {
    this.patientForm.reset({ status: 3 });
    this.isModalOpen = true;
  }

  save() {
    if (this.patientForm.invalid) return;
    this.patientService.create(this.patientForm.value).subscribe(() => {
      this.isModalOpen = false;
      this.loadPatients();
    });
  }

  deletePatient(id: string) {
    if (confirm("Bu hastayı taburcu etmek istediğinize emin misiniz?")) {
      this.patientService.delete(id).subscribe(() => this.loadPatients());
    }
  }

  getStatusBadge(status: number): string {
    const s = status !== undefined ? status : 3;
    switch (s) {
      case 1: return 'bg-danger';
      case 2: return 'bg-warning text-dark';
      case 3: return 'bg-success';
      default: return 'bg-secondary';
    }
  }
}