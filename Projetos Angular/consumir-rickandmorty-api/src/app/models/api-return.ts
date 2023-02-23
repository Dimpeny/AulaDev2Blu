export class ApiReturn {
  count?: number;
  pages?: number;
  next?: string;
  prev?: string;
  results?: Results[];

  constructor (obj: Partial<ApiReturn>){
    Object.assign(this,obj)
  }
}

export class Results {
  id?: number;
  name?: string;
  status?: string;
  image?: string;
  url?: string;

  constructor (obj: Partial<ApiReturn>){
    Object.assign(this,obj)
  }
}
