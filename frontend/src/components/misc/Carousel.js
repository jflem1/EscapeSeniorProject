import React from 'react'
import Carousel from 'react-bootstrap/Carousel';

const CarouselPic = () => {
  return (
    <>
    <Carousel style={{ maxWidth: '400px', margin: 'auto' }}>
      <Carousel.Item>
        <img
          className="d-block w-100"
          src="https://via.placeholder.com/400x300"
          alt="First slide"
        />
        <Carousel.Caption>
          <h3>Title</h3>
          <p>Caption</p>
        </Carousel.Caption>
      </Carousel.Item>

      <Carousel.Item>
        <img
          className="d-block w-100"
          src="https://via.placeholder.com/400x300"
          alt="Second slide"
        />
        <Carousel.Caption>
          <h3>Title</h3>
          <p>Caption</p>
        </Carousel.Caption>
      </Carousel.Item>
    </Carousel>
    </>
  )
}

export default CarouselPic