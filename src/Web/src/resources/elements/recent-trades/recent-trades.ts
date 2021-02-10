import { Top100 } from './../../models/market/top-100';
import {autoinject} from 'aurelia-framework';
import {Router} from 'aurelia-router';
import {connectTo} from 'aurelia-store';

@connectTo()
@autoinject()
export class RecentTrades{
  top100: Top100;
  processing: boolean;
  loadError: string='';
  constructor(){
    
  }
}
