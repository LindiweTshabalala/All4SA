import { Component } from '@angular/core';

import { Storage, ref, uploadBytesResumable, getDownloadURL } from '@angular/fire/storage'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'all4sa';
  public file: any = {}

  constructor(public storage: Storage) {}

  chooseFile(event: any) {
    this.file = event.target.files[0];
  }
  
  uploadImage() {
    const storageRef = ref(this.storage, this.file.name);
    const uploadTask = uploadBytesResumable(storageRef, this.file);
    uploadTask.on('state_changed',
      (snapshot) => {
        const progress = (snapshot.bytesTransferred / snapshot.totalBytes) * 100;
        console.log('Upload is ' + progress + '% done');
      },
      (error) =>{},
      () => {
        console.log("lol");
        getDownloadURL(uploadTask.snapshot.ref).then((downloadURL) => {
          console.log('File available at', downloadURL);
        });
      }
    );
  }
}
