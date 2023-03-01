export interface jobRequest {
    jobRequestID: number,
    jobRequestDescription: string,
    userID: number,
    imageReferenceID: number,
    jobTypeID: number,
    estimatedCost: number,
    status: boolean
}

// {
//     "jobRequestID": 0,
//     "jobRequestDescription": "string",
//     "userID": 0,
//     "imageReferenceID": 0,
//     "jobTypeID": 0,
//     "estimatedCost": 0,
//     "status": true
//   }