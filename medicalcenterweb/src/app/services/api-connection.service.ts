import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IdentificationTypeDTO } from '../models/identificationType.model';
import { CustomerDTO } from '../models/customer.model';
import { CountryDTO } from '../models/country.model';
import { DepartmentDTO } from '../models/department.model';
import { CityDTO } from '../models/city.model';
import { Observable, catchError, map, of } from 'rxjs';
import { environment } from '../../envitoment/enviroment';

@Injectable({
  providedIn: 'root'
})

export class ApiConnectionService {
  private baseUrl: string = environment.baseUrl;

  constructor(private http: HttpClient) {}

  getIdentificationTypes(): Observable<IdentificationTypeDTO[]> {
    const url = `${this.baseUrl}/api/IdentificationType/GetIdentificationTypes`;
    return this.http.get<IdentificationTypeDTO[]>(url).pipe(
        catchError((error: any) => {
          console.error('Error getting all Identification Types:', error);
          return [];
        })
    );
  }

  getCountries(): Observable<CountryDTO[]> {
    const url = `${this.baseUrl}/api/Country/GetCountries`;
    return this.http.get<CountryDTO[]>(url).pipe(
        catchError((error: any) => {
          console.error('Error getting all countries:', error);
          return [];
        })
    );
  }

  getDepartmentsByCountryId(
    countryId: number,
  ): Observable<{ data: DepartmentDTO[] }> {
    let url = `${this.baseUrl}/api/Department/GetDepartmentsByCountryId?countryId=${countryId}`;

    return this.http.get<any>(url).pipe(
      map((response: any) => { 
        return {
          data: response.data
        };
      }),
      catchError((error: any) => {
        console.error('Error getting departments by Country Id:', error);
        return [];
      })
    );
  }

  getCitiesByDepartmentId(
    countryId: number,
  ): Observable<{ data: CityDTO[] }> {
    let url = `${this.baseUrl}/api/City/GetCitiesByDepartmentId?departmentId=${countryId}`;

    return this.http.get<any>(url).pipe(
      map((response: any) => { 
        return {
          data: response.data
        };
      }),
      catchError((error: any) => {
        console.error('Error getting cities by Department Id:', error);
        return [];
      })
    );
  } 
}
