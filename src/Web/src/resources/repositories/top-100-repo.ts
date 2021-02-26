import {inject} from 'aurelia-framework';
import {Config} from 'aurelia-api';

@inject(Config)
export class Top100Repo{
  constructor(config){
    this.apiEndpoint = config.getEndpoint('protected-api');
    
  }
}
