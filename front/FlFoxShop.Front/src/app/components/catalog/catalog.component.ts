import { Component } from "@angular/core";
import { TestService } from "../../services/test-service";

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrl: './catalog.component.scss'
})
export class CatalogComponent {

    protected text: string = "";

    constructor(private service: TestService) {

    }

    protected getTest() {
        this.service.getTest().subscribe(data => {
            this.text = data
        })
    }
}