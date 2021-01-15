import { PLATFORM } from 'aurelia-pal';
import {Router, RouteConfig, RouterConfiguration} from 'aurelia-router';

export class AppShell{
  router: Router;
  
  configureRouter(config: RouterConfiguration, router: Router): void {
    this.router = router;
    const routes: RouteConfig[]=[
      {route: '', redirect:'home'},
      {route: 'home', name:'home', moduleId: PLATFORM.moduleName('app-shell/home/home'), title: 'Bitcoin Exchange', href: '#/home', nav: true}
    ]
    config.map(routes);
  }
}
