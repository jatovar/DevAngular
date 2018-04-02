import { Injectable,Inject } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from '@angular/http';

import 'rxjs/add/operator/map';
import { Car } from '../models/Car';


@Injectable()
export class CarService {

    public _baseUrl : string;

    constructor(public _http: Http, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    getCars() {
        return this._http.get(this._baseUrl  + 'api/Car').map(res => res.json());
    }

    createCar(car : Car) {
        return this._http.put(this._baseUrl + 'api/Car', car ).map(res=> res.json());
    }
}
