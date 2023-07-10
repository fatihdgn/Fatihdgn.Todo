import { Injectable } from "@angular/core";
import { toSignal } from '@angular/core/rxjs-interop';
import { BehaviorSubject } from "rxjs";
import { State } from "../models/state.model";

@Injectable({
  providedIn: 'root'
})
export class StateService {
  private _value$: BehaviorSubject<State> = new BehaviorSubject<State>({
    items: [],
    lists: [],
    templates: [],
    currentItem: {},
    currentList: {},
    currentTemplate: {}
  });

  public get value$() {
    return toSignal(this._value$.asObservable());
  }

  public set value(value: State) {
    this._value$.next(value);
  }

  public get value(): State {
    return this._value$.getValue();
  }
}