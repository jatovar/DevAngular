import { Component } from '@angular/core';

import { CarService } from '../../services/CarService';
import { Car } from '../../models/Car';
import notify from 'devextreme/ui/notify';


@Component({
    selector: 'cars',
    templateUrl: './car.component.html',
    providers: [CarService]
})
export class CarComponent {

    public cars: Car[];

    constructor(private _carService: CarService) {
   
    }

     ngOnInit() {
        this.getCars();
    }

    getCars(){
        this._carService.getCars().subscribe(
            (response : any) => {
                this.cars = response;
            },
            (error : any) => {
                notify({
                        message: error,
                    }, "error", 3000);
            }
        );
    }
}


