export interface Job {
    jobRequestID: number,
    jobRequestDescription: string,
    userID: number,
    imageReference: string,
    jobTypeID: number,
    estimatedCost: number,
    status: boolean,
}

// {
//     "jobRequestID": 1,
//     "jobRequestDescription": "Installing a fence around a park",
//     "userID": 1,
//     "imageReferenceID": 1,
//     "jobTypeID": 1,
//     "estimatedCost": 100,
//     "status": false
//   },