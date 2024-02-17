import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { IconModule } from '@coreui/icons-angular';
import { ChartjsModule } from '@coreui/angular-chartjs';
import { ContentRoutingModule } from './content-routing.module';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { PanelModule } from 'primeng/panel';
import { BlockUIModule } from 'primeng/blockui';
import { PaginatorModule } from 'primeng/paginator';
import { BadgeModule } from 'primeng/badge';
import { CheckboxModule } from 'primeng/checkbox';
import { TableModule } from 'primeng/table';
import { KeyFilterModule } from 'primeng/keyfilter';
import { SonDaoSharedModule } from 'src/app/shared/modules/sondao-shared.module';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { PostCategoryComponent } from './post-categories/post-category.component';
import { PostCategoryDetailComponent } from './post-categories/post-category-detail.component';
import { DropdownModule } from 'primeng/dropdown';
import { InputNumberModule } from 'primeng/inputnumber';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { ImageModule } from 'primeng/image';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { EditorModule } from 'primeng/editor';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { PostComponent } from './posts/post.component';
import { PostDetailComponent } from './posts/post-detail.component';
import { PostSeriesComponent } from './posts/post-series.component';
import { PostActivityLogsComponent } from './posts/post-activity-logs.component';
import { PostReturnReasonComponent } from './posts/post-return-reason.component';
import { SeriesComponent } from './series/series.component';
import { SeriesDetailComponent } from './series/series-detail.component';
import { SeriesPostsComponent } from './series/series-posts.component';

@NgModule({
  imports: [
    ContentRoutingModule,
    IconModule,
    CommonModule,
    ReactiveFormsModule,
    ChartjsModule,
    ProgressSpinnerModule,
    PanelModule,
    BlockUIModule,
    PaginatorModule,
    BadgeModule,
    CheckboxModule,
    TableModule,
    KeyFilterModule,
    SonDaoSharedModule,
    ButtonModule,
    InputTextModule,
    InputTextareaModule,
    DropdownModule,
    EditorModule,
    InputNumberModule,
    ImageModule,
    DynamicDialogModule,
    AutoCompleteModule
  ],
  declarations: [
    PostComponent,
    PostDetailComponent,
    PostCategoryComponent,
    PostCategoryDetailComponent,
    SeriesComponent,
    SeriesDetailComponent,
    PostReturnReasonComponent,
    PostSeriesComponent,
    SeriesPostsComponent,
    PostActivityLogsComponent
  ]
})
export class ContentModule {
}
