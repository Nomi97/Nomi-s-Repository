import React from 'react'
import './card.css'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'

function Card({ title, sections, icon }) {
  return (
    <article className='card'>
      <div className="card__icon">
        <FontAwesomeIcon size='3x' icon={icon} />
      </div>
      <div className="card__content">
        <h1 className='card__title'>{title}</h1>
        {sections.map(section => (
          <section className='card__details'>
            <h3 className='card__subtitle'>{section.title}</h3>
            <h4 className='card__date'>{`${section.date} ${section.country}`}</h4>
            <p className='card__description'>{section.content}</p>
            <div className="card__seperator"></div>
          </section>
        ))}
      </div>
    </article>

  )
}

export default Card