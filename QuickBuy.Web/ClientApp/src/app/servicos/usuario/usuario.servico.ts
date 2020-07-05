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

  set usuario(usuario: Usuario) {
    sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
    this._usuario = usuario;
  }

  get usuario(): Usuario {
    let usuario_json = sessionStorage.getItem("usuario-autenticado");
    this._usuario = JSON.parse(usuario_json);
    return this._usuario;
  }

  public usuario_autenticado(): boolean {
    return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
  }

  public limpar_sessao() {
    sessionStorage.setItem("usuario-autenticado", "");
    this._usuario = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public verificaUsuario(usuario: Usuario): Observable<Usuario> {
    const headers = new HttpHeaders().set('Content-Type', 'application/json');
    const urlTst = "https://localhost:44389/api/usuario/VerificarUsuario/";
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    console.log(this.baseURL);
    // this.baseURL == pega a raiz do site que poder der : www.quickbuy.com/
    return this.http.post<Usuario>(urlTst, body, { headers });
  }

}

