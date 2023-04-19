import { Component, OnInit } from '@angular/core';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.scss']
})
export class LayoutComponent implements OnInit {

  constructor(private alertify: AlertifyService) {
    this.alertify.message('Hello World', {
      messageType: MessageType.Success,
      position: Position.TopCenter,
      delay: 5,
      dismissOthers: true
    });
  }

  ngOnInit(): void {


  }

}
