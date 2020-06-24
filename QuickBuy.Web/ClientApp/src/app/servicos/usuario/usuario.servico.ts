import {  Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "../../model/usuario";

@Injectable({
  providedIn: "root"
})
export class UsuarioServico {

  private baseURL: string;
  private _usuario: Usuario;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;    
  }

  public verificaUsuario(usuario: Usuario): Observable<Usuario> {
    const headers = new HttpHeaders().set('Content-Type', 'application/json');
    
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    console.log(this.baseURL);
    // this.baseURL == pega a raiz do site que poder der : www.quickbuy.com/
    return this.http.post<Usuario>(this.baseURL + "api/usuario/VerificarUsuario", body, { headers });
  }

}

