import React from 'react'
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faUser, faPhoneAlt, faCode } from '@fortawesome/free-solid-svg-icons'
import './sidebar.css';
function Sidebar() {
  return (
    <aside className='sidebar'>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faUser} /> Profile</h2>
        <p>I am a junior developer with a passion for front-end development. I love working on challaging task that help me grow and evolve. I very ambious, goal driven and  persistent in solving and finding solutions to the problem</p>
      </section>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faPhoneAlt} /> Contact</h2>
        <ul>
          <li>+46 72 147 43 16</li>
          <li>Noman1997@hotmail.se</li>
          <li><a href='ttps://www.linkedin.com/in/noman-lone-1996a8168'>https://www.linkedin.com/in/noman-lone-1996a8168</a></li>
          <li> Sweden, Malmö</li>
        </ul>
      </section>
      <section className='sidebar__item'>
        <h2 className='sidebar__title'><FontAwesomeIcon icon={faCode} /> Skills</h2>
        <div className="sidebar__skills">
          <div>
            <label htmlFor="Javascript">Javascript</label>
            <progress id='Javascript' max="100" value="90"></progress>
          </div>
          <div>
            <label htmlFor="React">React</label>
            <progress id='React' max="100" value="90"></progress>
          </div>
          <div>
            <label htmlFor="HTML">HTML</label>
            <progress id='HTML' max="100" value="85"></progress>
          </div>
          <div>
            <label htmlFor="CSS">CSS</label>
            <progress id='CSS' max="100" value="85"></progress>
          </div>
          <div>
            <label htmlFor="Redux">Redux</label>
            <progress id='Redux' max="100" value="70"></progress>
          </div>
          <div>
            <label htmlFor="Sass">Sass</label>
            <progress id='Sass' max="100" value="60"></progress>
          </div>
          <div>
            <label htmlFor="Rxjs">Rxjs</label>
            <progress id='Rxjs' max="100" value="35"></progress>
          </div>
          <div>
            <label htmlFor="Webpack">Webpack</label>
            <progress id='Webpack' max="100" value="30"></progress>
          </div>
          <div>
            <label htmlFor="Node">Node</label>
            <progress id='Node' max="100" value="25"></progress>
          </div>
        </div>
      </section>
    </aside>
  )
}

export default Sidebar;