import {FrameworkConfiguration} from 'aurelia-framework';
import {PLATFORM} from 'aurelia-pal';

export function configure(config: FrameworkConfiguration): void {
  config.globalResources([
    PLATFORM.moduleName('./elements/chart/btc-chart'),
    PLATFORM.moduleName('./elements/recent-trades/recent-trades'),
    PLATFORM.moduleName('./elements/buy-sell/buy-sell')
  ]);
}
