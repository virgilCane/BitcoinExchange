export class Order{
  price:string;
  volume:string;

  constructor({
    price,
    volume
  }: Partial<Order> ={}){
    this.price = price;
    this.volume = volume;
  }
}
