import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class TestService {

    private baseUrl = "https://localhost:7203/TestContoroller/";

    constructor(private client: HttpClient) {

    }

    public  getTest(): Observable<string> {
        return this.client.get(this.baseUrl+"test", { responseType: "text"}); 
    }
}