import {Order} from './order';
export class Top100{
  timestamp: string;
  bids: Array<Order>;
  asks: Array<Order>;

  constructor({timestamp, bids,asks}: Partial<Top100> = {}){
    this.timestamp = timestamp;
    this.bids = bids;
    this.asks = asks;
  }
}
