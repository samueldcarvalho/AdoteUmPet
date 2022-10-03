import { LocalStorageUtils } from './../../utils/local-storage';
import { HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { throwError } from "rxjs";

export abstract class BaseService {
  protected UrlService: string = "https://localhost:5001/api/v1";
  public localStorage = new LocalStorageUtils();

  protected getHeaderJson(){
    return {
      headers: new HttpHeaders({
        'content-type': 'application/json'
      })
    }
  }

  protected serviceError(response: Response | any) {
    let customError: string[] = [];

    if(response instanceof HttpErrorResponse)
    {
      if(response.statusText === "Unknown Error"){
        customError.push("Unable to communicate with the API");
      }

      if(response.error.length > 0){
        for (let error of response.error){
          customError.push(error.description);
        }
      }

      response.error.errors = customError;
    }

    console.error(response);
    return throwError(response);
  }
}
