import React from 'react'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faUser, faPhoneAlt, faCode } from '@fortawesome/free-solid-svg-icons'
import './sidebar.css';
function Sidebar() {
  return (
    <aside className='sidebar'>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faUser} /> Profile</h2>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Excepturi per Lorem ipsum dolor sit amet consectetur adipisicing elit. Excepturi per</p>
      </section>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faPhoneAlt} /> Contact</h2>
        <ul>
          <li>+46 72 147 43 16</li>
          <li>Noman1997@hotmail.se</li>
          <li>Link</li>
          <li> Sweden, Malmö</li>
        </ul>
      </section>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faCode} /> Skills</h2>
        <div>
          <label htmlFor="test">HTML</label>
          <progress id='test' max="100" value="85"></progress>
        </div>
        <div>
          <label htmlFor="test">CSS</label>
          <progress id='test' max="100" value="85"></progress>
        </div>
        <div>
          <label htmlFor="test">Javascript</label>
          <progress id='test' max="100" value="90"></progress>
        </div>
        <div>
          <label htmlFor="test">React</label>
          <progress id='test' max="100" value="90"></progress>
        </div>
      </section>
    </aside>
  )
}

export default Sidebar;