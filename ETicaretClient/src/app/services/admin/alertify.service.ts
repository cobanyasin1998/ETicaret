import { Injectable } from '@angular/core';
declare var alertify: any;
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() {

  }
  message(message: string, options: Partial<AlertifyOptions>) {
    alertify.set('notifier', 'delay', options.delay);
    alertify.set('notifier', 'position', options.position);
    const msj = alertify[options.messageType](message);
    if (options.dismissOthers) {
      msj.dismissOthers();
    }
  };

  dismissAll() {
    alertify.dismissAll();
  }
}
export class AlertifyOptions {
  messageType: MessageType = MessageType.Message;
  position: Position = Position.TopRight;
  delay: number = 5;
  dismissOthers: boolean = false;
}

export enum MessageType {
  Error = 'error',
  Success = 'success',
  Warning = 'warning',
  Message = 'message',
  Notify = 'notify'
}
export enum Position {
  BottomRight = 'bottom-right',
  BottomCenter = 'bottom-center',
  BottomLeft = 'bottom-left',
  TopRight = 'top-right',
  TopLeft = 'top-left',
  TopCenter = 'top-center',

}