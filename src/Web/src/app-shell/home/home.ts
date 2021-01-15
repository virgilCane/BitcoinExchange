import * as M from 'materialize-css';
export class Home{
  timestamp: string;
  parsedDate: Date;

  constructor(){
    this.timestamp = '1609161753091';
  }

  attached(){
    this.ParseDate(this.timestamp);
    //Initialize materialize elements
    M.AutoInit();
  }

  async ParseDate(ts:string){
    var stamp = Number(ts);
    var date = new Date(stamp);
    var day = date.getMonth().toString();
    console.log(day)
  }
  
}
