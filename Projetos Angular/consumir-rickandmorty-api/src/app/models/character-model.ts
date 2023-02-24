export class Character {
  id?: number;
  name?: string;
  status?: string;
  species?: string;
  type?: string;
  gender?: string;
  location?: Location = new Location({});
  origin?: Origin = new Origin({});
  image?: string;

  constructor(obj: Partial<Character>) {
    Object.assign(this, obj);
  }
}

export class Origin {
  name?: string;
  url?: string;
  constructor(obj: Partial<Origin>) {
    Object.assign(this, obj);
  }
}

export class Location {
  name?: string;
  url?: string;

  constructor(obj: Partial<Location>) {
    Object.assign(this, obj);
  }
}
