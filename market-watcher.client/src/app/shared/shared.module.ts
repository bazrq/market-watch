import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BannerComponent } from './banner/banner.component';
import {MenubarModule} from 'primeng/menubar';
import {MenuItem} from 'primeng/api';

@NgModule({
  declarations: [
    BannerComponent
  ],
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    MenubarModule,
  ],
  exports: [BannerComponent]
})
export class SharedModule { }
