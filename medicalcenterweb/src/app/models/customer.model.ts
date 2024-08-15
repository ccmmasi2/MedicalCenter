export class CustomerDTO {
    name: string = '';
    lastName: string = '';
    birthDay!: Date;
    identificationTypeId: number = 0;
    identification: number = 0;
    cityId: number = 0;
    active: boolean = true;
}
