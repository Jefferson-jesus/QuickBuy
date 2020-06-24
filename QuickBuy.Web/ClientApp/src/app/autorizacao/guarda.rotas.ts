import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router"
import { Route } from "@angular/compiler/src/core";

@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router) {

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
    var auth = sessionStorage.getItem("usuario-autenticado");
    
    if (auth == "1") {
      return true;
    }
    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
    // Se Usuario autenticado
    return true;
  }

}
