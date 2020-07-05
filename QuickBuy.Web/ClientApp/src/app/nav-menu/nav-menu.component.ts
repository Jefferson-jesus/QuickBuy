import { Component } from '@angular/core';
import { Router } from "@angular/router";
import { UsuarioServico } from '../servicos/usuario/usuario.servico';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router, private UsuarioServico: UsuarioServico) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  public usuarioLogado(): boolean {
    return this.UsuarioServico.usuario_autenticado();
  }

  sair() {
    this.UsuarioServico.limpar_sessao();
    this.router.navigate(['/']);
  }

}
