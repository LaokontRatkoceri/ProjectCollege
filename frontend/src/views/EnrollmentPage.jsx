import React, { useState, useEffect } from 'react';
import { Container, FormLabel } from 'react-bootstrap';
import axios from 'axios';

 const courses= [
     {
         id:1,
         name:'DB',
         faculty:'CompSci',
     },
     {
         id:2,
         name:'SD',
         faculty:'CompSci',
    },
    {
         id:3,
        name:'WEB',
        faculty:'CompSci',
    },
];

export const EnrollmentPage=()=>{
    const[courseList, setCourseList] = useState(courses);

    return<Container>
        {/* {courseList.map((crouse,index) => {
            return (
                <Row key={index}>
                    <Col xs={2}>
                        <FormLabel>Id:{subject.courseId}</FormLabel>
                    </Col>
                    <Col xs={4}>
                        <FormLabel>CourseName:{subject.courseName}</FormLabel>
                    </Col>
                    <Col xs={5}>
                        <FormLabel>Faculty:{subject.faculty}</FormLabel>
                    </Col>
                </Row>
            )
        })} */}
        <h1>Inside the code consists everything that should be listed here but just doesnt work
            , also the Payment page too 
        </h1>
    </Container>
}