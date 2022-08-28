import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BannerComponent } from './banner/banner.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    BannerComponent,],
  imports: [
    CommonModule,
    BrowserAnimationsModule
  ],
  exports: [BannerComponent]
})
export class SharedModule { }
